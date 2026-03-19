namespace VistaSGI
{
    partial class FrmLoginNuevaClave
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
            this.btnVerPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoin = new System.Windows.Forms.Button();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPregunta3 = new System.Windows.Forms.Label();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.btnVerPass.Location = new System.Drawing.Point(282, 105);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(39, 20);
            this.btnVerPass.TabIndex = 18;
            this.btnVerPass.Text = "Ver";
            this.btnVerPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerPass.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Repita Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login SGI - Seguridad";
            // 
            // btnLoin
            // 
            this.btnLoin.Location = new System.Drawing.Point(24, 315);
            this.btnLoin.Name = "btnLoin";
            this.btnLoin.Size = new System.Drawing.Size(117, 26);
            this.btnLoin.TabIndex = 13;
            this.btnLoin.Text = "Confirmar";
            this.btnLoin.UseVisualStyleBackColor = true;
            this.btnLoin.Click += new System.EventHandler(this.BtnLoin_Click);
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(24, 105);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(241, 20);
            this.txtPasword.TabIndex = 12;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(24, 61);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(241, 20);
            this.textUsername.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(282, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ver";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ingrese sus respuestas de seguridad";
            // 
            // lblPregunta3
            // 
            this.lblPregunta3.AutoSize = true;
            this.lblPregunta3.Location = new System.Drawing.Point(21, 255);
            this.lblPregunta3.Name = "lblPregunta3";
            this.lblPregunta3.Size = new System.Drawing.Size(13, 13);
            this.lblPregunta3.TabIndex = 26;
            this.lblPregunta3.Text = "3";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Location = new System.Drawing.Point(21, 216);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(13, 13);
            this.lblPregunta2.TabIndex = 25;
            this.lblPregunta2.Text = "2";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Location = new System.Drawing.Point(21, 177);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(13, 13);
            this.lblPregunta1.TabIndex = 24;
            this.lblPregunta1.Text = "1";
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(24, 232);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(634, 20);
            this.txtRespuesta2.TabIndex = 23;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Location = new System.Drawing.Point(24, 271);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(634, 20);
            this.txtRespuesta3.TabIndex = 22;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(24, 193);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(634, 20);
            this.txtRespuesta1.TabIndex = 21;
            // 
            // FrmLoginNuevaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPregunta3);
            this.Controls.Add(this.lblPregunta2);
            this.Controls.Add(this.lblPregunta1);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoin);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.textUsername);
            this.Name = "FrmLoginNuevaClave";
            this.Text = "FrmLoginSeguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoin;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPregunta3;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta1;
    }
}