namespace VistaSGI
{
    partial class FrmObraSocial
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
            this.txtNumAfil = new System.Windows.Forms.TextBox();
            this.cmbDescOsocial = new System.Windows.Forms.ComboBox();
            this.chcPoseeOsocial = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApNom = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumAfil
            // 
            this.txtNumAfil.Location = new System.Drawing.Point(44, 194);
            this.txtNumAfil.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumAfil.Name = "txtNumAfil";
            this.txtNumAfil.Size = new System.Drawing.Size(326, 20);
            this.txtNumAfil.TabIndex = 60;
            // 
            // cmbDescOsocial
            // 
            this.cmbDescOsocial.FormattingEnabled = true;
            this.cmbDescOsocial.Location = new System.Drawing.Point(243, 125);
            this.cmbDescOsocial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDescOsocial.Name = "cmbDescOsocial";
            this.cmbDescOsocial.Size = new System.Drawing.Size(97, 21);
            this.cmbDescOsocial.TabIndex = 59;
            // 
            // chcPoseeOsocial
            // 
            this.chcPoseeOsocial.AutoSize = true;
            this.chcPoseeOsocial.Location = new System.Drawing.Point(52, 129);
            this.chcPoseeOsocial.Margin = new System.Windows.Forms.Padding(2);
            this.chcPoseeOsocial.Name = "chcPoseeOsocial";
            this.chcPoseeOsocial.Size = new System.Drawing.Size(15, 14);
            this.chcPoseeOsocial.TabIndex = 58;
            this.chcPoseeOsocial.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Número Afiliado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Descripción Obra social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Posee Obra social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Apellido y Nombre";
            // 
            // txtApNom
            // 
            this.txtApNom.Location = new System.Drawing.Point(237, 48);
            this.txtApNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtApNom.Name = "txtApNom";
            this.txtApNom.Size = new System.Drawing.Size(149, 20);
            this.txtApNom.TabIndex = 53;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(32, 45);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(123, 20);
            this.txtDni.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Dni";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(422, 47);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(237, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(32, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 84;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNumAfil);
            this.Controls.Add(this.cmbDescOsocial);
            this.Controls.Add(this.chcPoseeOsocial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApNom);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Name = "FrmObraSocial";
            this.Text = "FrmObraSocial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumAfil;
        private System.Windows.Forms.ComboBox cmbDescOsocial;
        private System.Windows.Forms.CheckBox chcPoseeOsocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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