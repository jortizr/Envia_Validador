using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envia_Validador
{
    public partial class Validador: Form
    {
        public Validador()
        {
            InitializeComponent();
        }

        private void CapturarPortapapeles()
        {
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
                        dgvGuias.Rows.Add(columnas[0], columnas[1]);
                    }
                    else
                    {
                        MessageBox.Show("los datos pegados no contienen las dos columnas esperadas, vuelve a copiar los datos",
                            "formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvGuias.Rows.Clear();
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("No hay texto en el portapapeles", "portapapeles vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnPegarClick(object sender, EventArgs e)
        {
            CapturarPortapapeles();
        }

        private void btnLimpiarLista(object sender, EventArgs e)
        {
            dgvGuias.Rows.Clear();
        }
    }
}
