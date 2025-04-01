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
            this.dgvGuias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Guias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_Dest_List = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_Dest_Central = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuias
            // 
            this.dgvGuias.AllowUserToOrderColumns = true;
            this.dgvGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guia,
            this.Ciudad_Destino});
            this.dgvGuias.Location = new System.Drawing.Point(23, 79);
            this.dgvGuias.Name = "dgvGuias";
            this.dgvGuias.Size = new System.Drawing.Size(330, 428);
            this.dgvGuias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de guias a validar";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pegar del Portapapel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPegarClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Borrar lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLimpiarLista);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Validar Guias";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guias,
            this.Ciudad_Dest_List,
            this.Ciudad_Dest_Central,
            this.Estado_Guia});
            this.dataGridView1.Location = new System.Drawing.Point(492, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 429);
            this.dataGridView1.TabIndex = 5;
            // 
            // Guias
            // 
            this.Guias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guias.HeaderText = "Guia Consultada";
            this.Guias.Name = "Guias";
            // 
            // Ciudad_Dest_List
            // 
            this.Ciudad_Dest_List.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ciudad_Dest_List.HeaderText = "Ciudad Destino(Lista)";
            this.Ciudad_Dest_List.Name = "Ciudad_Dest_List";
            // 
            // Ciudad_Dest_Central
            // 
            this.Ciudad_Dest_Central.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ciudad_Dest_Central.HeaderText = "Ciudad Destino (Central)";
            this.Ciudad_Dest_Central.Name = "Ciudad_Dest_Central";
            // 
            // Estado_Guia
            // 
            this.Estado_Guia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado_Guia.HeaderText = "Estado actual";
            this.Estado_Guia.Name = "Estado_Guia";
            // 
            // Validador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGuias);
            this.Name = "Validador";
            this.Text = "Validador de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_Destino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_Dest_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_Dest_Central;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Guia;
    }
}

