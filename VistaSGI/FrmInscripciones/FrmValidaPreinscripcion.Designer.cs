namespace VistaSGI
{
    partial class FrmValidaPreinscripcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chcValidar = new System.Windows.Forms.CheckBox();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtLibroMatriz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chcProvicional = new System.Windows.Forms.CheckBox();
            this.cmbGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chcListaEspera = new System.Windows.Forms.CheckBox();
            this.chcDni = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chcTituloSec = new System.Windows.Forms.CheckBox();
            this.chcCertMed = new System.Windows.Forms.CheckBox();
            this.chcFoto = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.cmbConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaidación de preingreso";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(911, 148);
            this.dataGridView1.TabIndex = 1;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(12, 44);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(250, 21);
            this.cmbCarrera.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carrera";
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(284, 44);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(328, 21);
            this.cmbAlumno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alumno/a";
            // 
            // chcValidar
            // 
            this.chcValidar.AutoSize = true;
            this.chcValidar.Location = new System.Drawing.Point(67, 410);
            this.chcValidar.Name = "chcValidar";
            this.chcValidar.Size = new System.Drawing.Size(87, 17);
            this.chcValidar.TabIndex = 6;
            this.chcValidar.Text = "Validar datos";
            this.chcValidar.UseVisualStyleBackColor = true;
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(12, 279);
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.Size = new System.Drawing.Size(188, 20);
            this.txtSolicitud.TabIndex = 7;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(227, 279);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(140, 20);
            this.txtLegajo.TabIndex = 8;
            // 
            // txtLibroMatriz
            // 
            this.txtLibroMatriz.Location = new System.Drawing.Point(390, 279);
            this.txtLibroMatriz.Name = "txtLibroMatriz";
            this.txtLibroMatriz.Size = new System.Drawing.Size(133, 20);
            this.txtLibroMatriz.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identificador de Solicitud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Legajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Num. Libro Matriz";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(543, 279);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(133, 20);
            this.txtFolio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Num. Folio";
            // 
            // chcProvicional
            // 
            this.chcProvicional.AutoSize = true;
            this.chcProvicional.Location = new System.Drawing.Point(175, 410);
            this.chcProvicional.Name = "chcProvicional";
            this.chcProvicional.Size = new System.Drawing.Size(78, 17);
            this.chcProvicional.TabIndex = 15;
            this.chcProvicional.Text = "Provicional";
            this.chcProvicional.UseVisualStyleBackColor = true;
            // 
            // cmbGuardar
            // 
            this.cmbGuardar.Location = new System.Drawing.Point(11, 435);
            this.cmbGuardar.Name = "cmbGuardar";
            this.cmbGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmbGuardar.TabIndex = 16;
            this.cmbGuardar.Text = "Guardar";
            this.cmbGuardar.UseVisualStyleBackColor = true;
            this.cmbGuardar.Click += new System.EventHandler(this.CmbGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Datos Personales";
            // 
            // chcListaEspera
            // 
            this.chcListaEspera.AutoSize = true;
            this.chcListaEspera.Location = new System.Drawing.Point(280, 410);
            this.chcListaEspera.Name = "chcListaEspera";
            this.chcListaEspera.Size = new System.Drawing.Size(98, 17);
            this.chcListaEspera.TabIndex = 25;
            this.chcListaEspera.Text = "Lista de espera";
            this.chcListaEspera.UseVisualStyleBackColor = true;
            // 
            // chcDni
            // 
            this.chcDni.AutoSize = true;
            this.chcDni.Location = new System.Drawing.Point(168, 311);
            this.chcDni.Name = "chcDni";
            this.chcDni.Size = new System.Drawing.Size(75, 17);
            this.chcDni.TabIndex = 26;
            this.chcDni.Text = "Copia DNI";
            this.chcDni.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Documentación presentada:";
            // 
            // chcTituloSec
            // 
            this.chcTituloSec.AutoSize = true;
            this.chcTituloSec.Location = new System.Drawing.Point(257, 310);
            this.chcTituloSec.Name = "chcTituloSec";
            this.chcTituloSec.Size = new System.Drawing.Size(139, 17);
            this.chcTituloSec.TabIndex = 29;
            this.chcTituloSec.Text = "Copia Titulo Secundario";
            this.chcTituloSec.UseVisualStyleBackColor = true;
            // 
            // chcCertMed
            // 
            this.chcCertMed.AutoSize = true;
            this.chcCertMed.Location = new System.Drawing.Point(402, 311);
            this.chcCertMed.Name = "chcCertMed";
            this.chcCertMed.Size = new System.Drawing.Size(86, 17);
            this.chcCertMed.TabIndex = 30;
            this.chcCertMed.Text = "Cert. Médico";
            this.chcCertMed.UseVisualStyleBackColor = true;
            // 
            // chcFoto
            // 
            this.chcFoto.AutoSize = true;
            this.chcFoto.Location = new System.Drawing.Point(494, 310);
            this.chcFoto.Name = "chcFoto";
            this.chcFoto.Size = new System.Drawing.Size(67, 17);
            this.chcFoto.TabIndex = 31;
            this.chcFoto.Text = "Foto 4x4";
            this.chcFoto.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(92, 331);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(802, 71);
            this.txtObservaciones.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "División: ";
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(444, 408);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(271, 21);
            this.cmbDivision.TabIndex = 35;
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.Location = new System.Drawing.Point(665, 42);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmbConsultar.TabIndex = 36;
            this.cmbConsultar.Text = "Consultar";
            this.cmbConsultar.UseVisualStyleBackColor = true;
            this.cmbConsultar.Click += new System.EventHandler(this.CmbConsultar_Click);
            // 
            // FrmValidaPreinscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 634);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chcFoto);
            this.Controls.Add(this.chcCertMed);
            this.Controls.Add(this.chcTituloSec);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chcDni);
            this.Controls.Add(this.chcListaEspera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbGuardar);
            this.Controls.Add(this.chcProvicional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLibroMatriz);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtSolicitud);
            this.Controls.Add(this.chcValidar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmValidaPreinscripcion";
            this.Text = "frmValidaPreinscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chcValidar;
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtLibroMatriz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chcProvicional;
        private System.Windows.Forms.Button cmbGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chcListaEspera;
        private System.Windows.Forms.CheckBox chcDni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chcTituloSec;
        private System.Windows.Forms.CheckBox chcCertMed;
        private System.Windows.Forms.CheckBox chcFoto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Button cmbConsultar;
    }
}