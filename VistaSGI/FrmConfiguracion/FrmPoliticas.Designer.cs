namespace VistaSGI
{
    partial class FrmPoliticas
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
            this.label4 = new System.Windows.Forms.Label();
            this.chcMinimo = new System.Windows.Forms.CheckBox();
            this.chcPswAnterior = new System.Windows.Forms.CheckBox();
            this.chcMayuscula = new System.Windows.Forms.CheckBox();
            this.chcDatosPersonales = new System.Windows.Forms.CheckBox();
            this.chcMinuscula = new System.Windows.Forms.CheckBox();
            this.chcNumero = new System.Windows.Forms.CheckBox();
            this.chcEspecial = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.chcFallidos = new System.Windows.Forms.CheckBox();
            this.chcDiasDesbloqueo = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Politicas contraseña SGI";
            // 
            // chcMinimo
            // 
            this.chcMinimo.AutoSize = true;
            this.chcMinimo.Location = new System.Drawing.Point(15, 42);
            this.chcMinimo.Name = "chcMinimo";
            this.chcMinimo.Size = new System.Drawing.Size(113, 17);
            this.chcMinimo.TabIndex = 1;
            this.chcMinimo.Text = "Minimo Caracteres";
            this.chcMinimo.UseVisualStyleBackColor = true;
            // 
            // chcPswAnterior
            // 
            this.chcPswAnterior.AutoSize = true;
            this.chcPswAnterior.Location = new System.Drawing.Point(167, 42);
            this.chcPswAnterior.Name = "chcPswAnterior";
            this.chcPswAnterior.Size = new System.Drawing.Size(136, 17);
            this.chcPswAnterior.TabIndex = 5;
            this.chcPswAnterior.Text = "No Contraseña Anterior";
            this.chcPswAnterior.UseVisualStyleBackColor = true;
            // 
            // chcMayuscula
            // 
            this.chcMayuscula.AutoSize = true;
            this.chcMayuscula.Location = new System.Drawing.Point(15, 65);
            this.chcMayuscula.Name = "chcMayuscula";
            this.chcMayuscula.Size = new System.Drawing.Size(77, 17);
            this.chcMayuscula.TabIndex = 2;
            this.chcMayuscula.Text = "Mayúscula";
            this.chcMayuscula.UseVisualStyleBackColor = true;
            // 
            // chcDatosPersonales
            // 
            this.chcDatosPersonales.AutoSize = true;
            this.chcDatosPersonales.Location = new System.Drawing.Point(167, 65);
            this.chcDatosPersonales.Name = "chcDatosPersonales";
            this.chcDatosPersonales.Size = new System.Drawing.Size(126, 17);
            this.chcDatosPersonales.TabIndex = 6;
            this.chcDatosPersonales.Text = "No Datos Personales";
            this.chcDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // chcMinuscula
            // 
            this.chcMinuscula.AutoSize = true;
            this.chcMinuscula.Location = new System.Drawing.Point(15, 88);
            this.chcMinuscula.Name = "chcMinuscula";
            this.chcMinuscula.Size = new System.Drawing.Size(74, 17);
            this.chcMinuscula.TabIndex = 3;
            this.chcMinuscula.Text = "Minúscula";
            this.chcMinuscula.UseVisualStyleBackColor = true;
            // 
            // chcNumero
            // 
            this.chcNumero.AutoSize = true;
            this.chcNumero.Location = new System.Drawing.Point(167, 88);
            this.chcNumero.Name = "chcNumero";
            this.chcNumero.Size = new System.Drawing.Size(71, 17);
            this.chcNumero.TabIndex = 7;
            this.chcNumero.Text = "Numérico";
            this.chcNumero.UseVisualStyleBackColor = true;
            // 
            // chcEspecial
            // 
            this.chcEspecial.AutoSize = true;
            this.chcEspecial.Location = new System.Drawing.Point(15, 111);
            this.chcEspecial.Name = "chcEspecial";
            this.chcEspecial.Size = new System.Drawing.Size(109, 17);
            this.chcEspecial.TabIndex = 4;
            this.chcEspecial.Text = "Caracter Especial";
            this.chcEspecial.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(15, 181);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(68, 21);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // chcFallidos
            // 
            this.chcFallidos.AutoSize = true;
            this.chcFallidos.Location = new System.Drawing.Point(167, 111);
            this.chcFallidos.Name = "chcFallidos";
            this.chcFallidos.Size = new System.Drawing.Size(102, 17);
            this.chcFallidos.TabIndex = 8;
            this.chcFallidos.Text = "Intentos Fallidos";
            this.chcFallidos.UseVisualStyleBackColor = true;
            // 
            // chcDiasDesbloqueo
            // 
            this.chcDiasDesbloqueo.AutoSize = true;
            this.chcDiasDesbloqueo.Location = new System.Drawing.Point(167, 133);
            this.chcDiasDesbloqueo.Name = "chcDiasDesbloqueo";
            this.chcDiasDesbloqueo.Size = new System.Drawing.Size(107, 17);
            this.chcDiasDesbloqueo.TabIndex = 9;
            this.chcDiasDesbloqueo.Text = "Dias Desbloqueo";
            this.chcDiasDesbloqueo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 21);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPoliticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chcDiasDesbloqueo);
            this.Controls.Add(this.chcFallidos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.chcEspecial);
            this.Controls.Add(this.chcNumero);
            this.Controls.Add(this.chcMinuscula);
            this.Controls.Add(this.chcDatosPersonales);
            this.Controls.Add(this.chcMayuscula);
            this.Controls.Add(this.chcPswAnterior);
            this.Controls.Add(this.chcMinimo);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPoliticas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPoliticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chcMinimo;
        private System.Windows.Forms.CheckBox chcPswAnterior;
        private System.Windows.Forms.CheckBox chcMayuscula;
        private System.Windows.Forms.CheckBox chcDatosPersonales;
        private System.Windows.Forms.CheckBox chcMinuscula;
        private System.Windows.Forms.CheckBox chcNumero;
        private System.Windows.Forms.CheckBox chcEspecial;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox chcFallidos;
        private System.Windows.Forms.CheckBox chcDiasDesbloqueo;
        private System.Windows.Forms.Button btnSalir;
    }
}