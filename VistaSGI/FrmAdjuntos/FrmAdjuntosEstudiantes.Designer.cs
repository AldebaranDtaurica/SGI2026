namespace VistaSGI
{
    partial class FrmAdjuntosEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.ListBox listBoxArchivos;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.listBoxArchivos = new System.Windows.Forms.ListBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Location = new System.Drawing.Point(12, 12);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(120, 23);
            this.btnCargarArchivos.TabIndex = 0;
            this.btnCargarArchivos.Text = "Cargar Archivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(138, 12);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(120, 23);
            this.btnAbrirArchivo.TabIndex = 1;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // listBoxArchivos
            // 
            this.listBoxArchivos.FormattingEnabled = true;
            this.listBoxArchivos.Location = new System.Drawing.Point(12, 70);
            this.listBoxArchivos.Name = "listBoxArchivos";
            this.listBoxArchivos.Size = new System.Drawing.Size(356, 212);
            this.listBoxArchivos.TabIndex = 2;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(12, 41);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCategorias.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 21);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAdjuntosEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 353);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.listBoxArchivos);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.btnCargarArchivos);
            this.Name = "FrmAdjuntosEstudiantes";
            this.Text = "Adjuntos Estudiantes";
            this.Load += new System.EventHandler(this.FrmAdjuntosEstudiantes_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnSalir;
    }
}
#endregion