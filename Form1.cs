using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envia_Validador
{
    public partial class Validador: Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string ApiUrlConsulta = "https://hub.envia.co/ServicioRESTConsultaEstados/Service1Consulta.svc/ConsultaGuia/";

        public Validador()
        {
            InitializeComponent();
        }

        private async Task ConsultarEstadoGuia()
        {
            int totalGuias = dgvGuias.Rows.Count;
            if (totalGuias == 0)
            {
                MessageBox.Show("No hay guias para validar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //carga de la barras de progreso
            progressBarGuias.Value = 0;
            progressBarGuias.Minimum = 0;
            progressBarGuias.Maximum = totalGuias;

            // Actualizar etiqueta al inicio
            txtPorcentaje.Text = $"0% {totalGuias}";
            int procesadas = 0;

            foreach (DataGridViewRow fila in dgvGuias.Rows) 
            {
                if (fila.Cells[0].Value == null) continue;

                string guia = fila.Cells[0].Value.ToString();
                string urlConsulta = ApiUrlConsulta + guia;

                try 
                { 
                    string jsonRespuesta = await _httpClient.GetStringAsync(urlConsulta);
                    JObject respuestaGet = JObject.Parse(jsonRespuesta);

                    string ciudadDestinoApi = respuestaGet["ciudad_destino"]?.ToString();
                    string estadoApi = respuestaGet["estado"]?.ToString();

                    fila.Cells[2].Value = ciudadDestinoApi;
                    fila.Cells[3].Value = estadoApi;

                    //valida si la ciudad de la lista coincide con la ciudad de la api
                    if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() != ciudadDestinoApi)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    fila.DefaultCellStyle.BackColor = Color.Gray;
                    fila.Cells[3].Value = "Error"; 
                    MessageBox.Show("Error al consultar la guia " + guia + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                progressBarGuias.Value++;
                procesadas++;

                //calcular el porcentaje de progreso
                int porcentaje = (procesadas * 100) / totalGuias;
                int faltantes = totalGuias - procesadas;
                txtPorcentaje.Text = $"{porcentaje}% - {faltantes}/{totalGuias}";

                await Task.Delay(50);
            }
            txtPorcentaje.Text = "Consulta finalizada ✅";
            MessageBox.Show("Consulta finalizada exitosamente", "Consulta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CapturarPortapapeles()
        {
            try {
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();
                    string[] lineas = clipboardText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    dgvGuias.Rows.Clear();
                    foreach (string linea in lineas)
                    {
                        string[] columnas = linea.Split('\t');

                        if (columnas.Length == 2)
                        {
                            dgvGuias.Rows.Add(columnas[0], columnas[1].ToUpper());
                        }
                        else
                        {
                            MessageBox.Show("los datos pegados no contienen las dos columnas esperadas, vuelve a copiar los datos GUIA y CIUDAD-DEPT",
                                "formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvGuias.Rows.Clear();
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar el portapapeles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("No hay texto en el portapapeles", "portapapeles vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
        }


        //funcion para organizar las filas que ya tienen un color rojo de primeras y las verdes de ultimas
        private void OrganizarFilas()
        {
            List<DataGridViewRow> filasRojo = new List<DataGridViewRow>();
            List<DataGridViewRow> filasVerde = new List<DataGridViewRow>();
            List<DataGridViewRow> filasGris = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in dgvGuias.Rows)
            {
                if (fila.DefaultCellStyle.BackColor == Color.Red)
                {
                    filasRojo.Add(fila);
                }
                else if (fila.DefaultCellStyle.BackColor == Color.Green)
                {
                    filasVerde.Add(fila);
                }
                else
                {
                    filasGris.Add(fila);
                }
            }
            dgvGuias.Rows.Clear();
            dgvGuias.Rows.AddRange(filasRojo.ToArray());
            dgvGuias.Rows.AddRange(filasGris.ToArray());
            dgvGuias.Rows.AddRange(filasVerde.ToArray());
        }



        private void btnPegarClick(object sender, EventArgs e)
        {
            CapturarPortapapeles();
        }

        private void btnLimpiarLista(object sender, EventArgs e)
        {
            dgvGuias.Rows.Clear();
            txtPorcentaje.Text = "0%";
        }

        private async void btnValidarGuiasAPI(object sender, EventArgs e)
        {
            await ConsultarEstadoGuia();
            OrganizarFilas();

        }
    }
}
