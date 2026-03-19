namespace VistaSGI
{
    partial class FrmLoginActualizacion
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
            this.lblErrores = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerPass = new System.Windows.Forms.Button();
            this.btnVerPass2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(39, 188);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(40, 13);
            this.lblErrores.TabIndex = 25;
            this.lblErrores.Text = "Errores";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 24);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(42, 231);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 24);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(39, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nueva contraseña SGI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nueva Contraseña";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(42, 132);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(266, 20);
            this.txtPassword2.TabIndex = 20;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(42, 75);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(266, 20);
            this.txtPassword1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Repita Contraseña";
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
            this.btnVerPass.Location = new System.Drawing.Point(338, 75);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(39, 20);
            this.btnVerPass.TabIndex = 27;
            this.btnVerPass.Text = "Ver";
            this.btnVerPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerPass.UseVisualStyleBackColor = false;
            this.btnVerPass.Click += new System.EventHandler(this.btnVerPass_Click);
            // 
            // btnVerPass2
            // 
            this.btnVerPass2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPass2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerPass2.FlatAppearance.BorderSize = 0;
            this.btnVerPass2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnVerPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPass2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerPass2.Location = new System.Drawing.Point(338, 132);
            this.btnVerPass2.Name = "btnVerPass2";
            this.btnVerPass2.Size = new System.Drawing.Size(39, 20);
            this.btnVerPass2.TabIndex = 28;
            this.btnVerPass2.Text = "Ver";
            this.btnVerPass2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerPass2.UseVisualStyleBackColor = false;
            this.btnVerPass2.Click += new System.EventHandler(this.btnVerPass2_Click);
            // 
            // FrmLoginActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 303);
            this.Controls.Add(this.btnVerPass2);
            this.Controls.Add(this.btnVerPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Name = "FrmLoginActualizacion";
            this.Text = "frmLoginActualizacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerPass;
        private System.Windows.Forms.Button btnVerPass2;
    }
}