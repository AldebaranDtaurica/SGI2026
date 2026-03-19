namespace VistaSGI
{
    partial class FrmOperaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.nmrYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.chcTuvoOp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApNom = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYear)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrYear
            // 
            this.nmrYear.Location = new System.Drawing.Point(217, 107);
            this.nmrYear.Margin = new System.Windows.Forms.Padding(2);
            this.nmrYear.Name = "nmrYear";
            this.nmrYear.Size = new System.Drawing.Size(74, 20);
            this.nmrYear.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Año (última)";
            // 
            // txtDiag
            // 
            this.txtDiag.Location = new System.Drawing.Point(31, 166);
            this.txtDiag.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiag.Multiline = true;
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(560, 91);
            this.txtDiag.TabIndex = 62;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(29, 151);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(120, 13);
            this.lbl.TabIndex = 61;
            this.lbl.Text = "Diagnosticos relevantes";
            // 
            // chcTuvoOp
            // 
            this.chcTuvoOp.AutoSize = true;
            this.chcTuvoOp.Location = new System.Drawing.Point(38, 109);
            this.chcTuvoOp.Margin = new System.Windows.Forms.Padding(2);
            this.chcTuvoOp.Name = "chcTuvoOp";
            this.chcTuvoOp.Size = new System.Drawing.Size(15, 14);
            this.chcTuvoOp.TabIndex = 60;
            this.chcTuvoOp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "¿ Tuvo operaciones ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Apellido y Nombre";
            // 
            // txtApNom
            // 
            this.txtApNom.Location = new System.Drawing.Point(231, 33);
            this.txtApNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtApNom.Name = "txtApNom";
            this.txtApNom.Size = new System.Drawing.Size(149, 20);
            this.txtApNom.TabIndex = 57;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(26, 30);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(123, 20);
            this.txtDni.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Dni";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(402, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(171, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 86;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(32, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nmrYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.chcTuvoOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApNom);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Name = "FrmOperaciones";
            this.Text = "FrmOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.nmrYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.CheckBox chcTuvoOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApNom;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}