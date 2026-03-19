namespace VistaSGI
{
    partial class FrmLogin
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
            this.btnLoin = new System.Windows.Forms.Button();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.lnkRecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoin
            // 
            this.btnLoin.Location = new System.Drawing.Point(49, 171);
            this.btnLoin.Name = "btnLoin";
            this.btnLoin.Size = new System.Drawing.Size(117, 26);
            this.btnLoin.TabIndex = 5;
            this.btnLoin.Text = "Confirmar";
            this.btnLoin.UseVisualStyleBackColor = true;
            this.btnLoin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(49, 119);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(241, 20);
            this.txtPasword.TabIndex = 4;
            this.txtPasword.TextChanged += new System.EventHandler(this.txtPasword_TextChanged);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(49, 75);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(241, 20);
            this.textUsername.TabIndex = 3;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // lnkRecuperarContrasena
            // 
            this.lnkRecuperarContrasena.AutoSize = true;
            this.lnkRecuperarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRecuperarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRecuperarContrasena.Location = new System.Drawing.Point(208, 176);
            this.lnkRecuperarContrasena.Name = "lnkRecuperarContrasena";
            this.lnkRecuperarContrasena.Size = new System.Drawing.Size(149, 15);
            this.lnkRecuperarContrasena.TabIndex = 6;
            this.lnkRecuperarContrasena.TabStop = true;
            this.lnkRecuperarContrasena.Text = "Recuperar contraseña";
            this.lnkRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login SGI";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Location = new System.Drawing.Point(48, 59);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(43, 13);
            this.lblPregunta1.TabIndex = 8;
            this.lblPregunta1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // btnVerPass
            // 
            this.btnVerPass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerPass.FlatAppearance.BorderSize = 0;
            this.btnVerPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnVerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPass.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerPass.Location = new System.Drawing.Point(307, 119);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(39, 20);
            this.btnVerPass.TabIndex = 10;
            this.btnVerPass.Text = "Ver";
            this.btnVerPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerPass.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 223);
            this.Controls.Add(this.btnVerPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPregunta1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkRecuperarContrasena);
            this.Controls.Add(this.btnLoin);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.textUsername);
            this.Name = "FrmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoin;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.LinkLabel lnkRecuperarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerPass;
    }
}

