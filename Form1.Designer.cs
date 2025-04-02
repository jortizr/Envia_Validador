namespace Envia_Validador
{
    partial class Validador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validador));
            this.dgvGuias = new System.Windows.Forms.DataGridView();
            this.Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_Dest_Central = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnValidarGuias = new System.Windows.Forms.Button();
            this.progressBarGuias = new System.Windows.Forms.ProgressBar();
            this.txtPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuias
            // 
            this.dgvGuias.AllowUserToAddRows = false;
            this.dgvGuias.AllowUserToOrderColumns = true;
            this.dgvGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guia,
            this.Ciudad_Destino,
            this.Ciudad_Dest_Central,
            this.Estado_Guia});
            this.dgvGuias.Location = new System.Drawing.Point(15, 30);
            this.dgvGuias.Name = "dgvGuias";
            this.dgvGuias.Size = new System.Drawing.Size(663, 403);
            this.dgvGuias.TabIndex = 0;
            // 
            // Guia
            // 
            this.Guia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guia.HeaderText = "Guia";
            this.Guia.Name = "Guia";
            // 
            // Ciudad_Destino
            // 
            this.Ciudad_Destino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ciudad_Destino.HeaderText = "Ciudad Destino";
            this.Ciudad_Destino.Name = "Ciudad_Destino";
            // 
            // Ciudad_Dest_Central
            // 
            this.Ciudad_Dest_Central.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ciudad_Dest_Central.HeaderText = "Cuiudad Destino (central)";
            this.Ciudad_Dest_Central.Name = "Ciudad_Dest_Central";
            // 
            // Estado_Guia
            // 
            this.Estado_Guia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado_Guia.HeaderText = "Estado actual";
            this.Estado_Guia.Name = "Estado_Guia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de guias a validar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pegar del Portapapel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPegarClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Borrar lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLimpiarLista);
            // 
            // btnValidarGuias
            // 
            this.btnValidarGuias.Location = new System.Drawing.Point(684, 113);
            this.btnValidarGuias.Name = "btnValidarGuias";
            this.btnValidarGuias.Size = new System.Drawing.Size(122, 29);
            this.btnValidarGuias.TabIndex = 4;
            this.btnValidarGuias.Text = "Validar Guias";
            this.btnValidarGuias.UseVisualStyleBackColor = true;
            this.btnValidarGuias.Click += new System.EventHandler(this.btnValidarGuiasAPI);
            // 
            // progressBarGuias
            // 
            this.progressBarGuias.Location = new System.Drawing.Point(124, 434);
            this.progressBarGuias.Name = "progressBarGuias";
            this.progressBarGuias.Size = new System.Drawing.Size(467, 20);
            this.progressBarGuias.Step = 1;
            this.progressBarGuias.TabIndex = 5;
            this.progressBarGuias.Tag = "";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.AutoSize = true;
            this.txtPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.ForeColor = System.Drawing.Color.Transparent;
            this.txtPorcentaje.Location = new System.Drawing.Point(597, 436);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(30, 17);
            this.txtPorcentaje.TabIndex = 6;
            this.txtPorcentaje.Text = "0%";
            // 
            // Validador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(832, 459);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.progressBarGuias);
            this.Controls.Add(this.btnValidarGuias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGuias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Validador";
            this.Text = "Validador de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnValidarGuias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_Dest_Central;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Guia;
        private System.Windows.Forms.ProgressBar progressBarGuias;
        private System.Windows.Forms.Label txtPorcentaje;
    }
}

