namespace VistaSGI.FrmConfiguracion
{
    partial class FrmMantenimientoBD
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
            this.btnBackUP = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMantIndices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReducirLog = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackUP
            // 
            this.btnBackUP.Location = new System.Drawing.Point(48, 38);
            this.btnBackUP.Name = "btnBackUP";
            this.btnBackUP.Size = new System.Drawing.Size(75, 23);
            this.btnBackUP.TabIndex = 0;
            this.btnBackUP.Text = "BackUP";
            this.btnBackUP.UseVisualStyleBackColor = true;
            this.btnBackUP.Click += new System.EventHandler(this.BtnBackUP_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(48, 111);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMantIndices
            // 
            this.btnMantIndices.Location = new System.Drawing.Point(47, 276);
            this.btnMantIndices.Name = "btnMantIndices";
            this.btnMantIndices.Size = new System.Drawing.Size(146, 23);
            this.btnMantIndices.TabIndex = 2;
            this.btnMantIndices.Text = "Mantenimiento de Indices";
            this.btnMantIndices.UseVisualStyleBackColor = true;
            this.btnMantIndices.Click += new System.EventHandler(this.BtnMantIndices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realiza un resguardo de la base de datos altual SGInst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaura la base base de datos al último resguardo realizado, genera un resguardo" +
    " de la base actual comprimido SGInst_año_mes_día";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Realiza un mantenimiento de indices y paginación, mejora la performance.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\SGInst\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\SGInst\\Rest" +
    "ore\\";
            // 
            // btnReducirLog
            // 
            this.btnReducirLog.Location = new System.Drawing.Point(47, 195);
            this.btnReducirLog.Name = "btnReducirLog";
            this.btnReducirLog.Size = new System.Drawing.Size(95, 23);
            this.btnReducirLog.TabIndex = 8;
            this.btnReducirLog.Text = "Reducir Log";
            this.btnReducirLog.UseVisualStyleBackColor = true;
            this.btnReducirLog.Click += new System.EventHandler(this.btnReducirLog_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Realiza la reducción de log de la base de datos, y un respaldo SGInst_LogBackup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(541, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ubicación del Log Reducido: C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPR" +
    "ESS\\MSSQL\\DATA\\";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(545, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Respaldo Log: C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Back" +
    "up\\SGInst\\Logs\\";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(680, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 21);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMantenimientoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReducirLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMantIndices);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBackUP);
            this.Name = "FrmMantenimientoBD";
            this.Text = "FrmMantenimientoBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackUP;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMantIndices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReducirLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
    }
}