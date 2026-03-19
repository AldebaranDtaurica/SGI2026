namespace VistaSGI
{
    partial class FrmAsignaciones
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
            this.lblfrm = new System.Windows.Forms.Label();
            this.dtgRolesUsr = new System.Windows.Forms.DataGridView();
            this.lblUsusario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.dtgRolesExtra = new System.Windows.Forms.DataGridView();
            this.lblSinAsignar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnIrMenu = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblMailUsuario = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAccionesRoles = new System.Windows.Forms.Label();
            this.lblUsuarioSelect = new System.Windows.Forms.Label();
            this.lblUsuarioId = new System.Windows.Forms.Label();
            this.RdbAlta = new System.Windows.Forms.RadioButton();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblUsuarioDoc = new System.Windows.Forms.Label();
            this.lblUsrId = new System.Windows.Forms.Label();
            this.ChcCondicion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRolesUsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRolesExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfrm
            // 
            this.lblfrm.AutoSize = true;
            this.lblfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblfrm.Location = new System.Drawing.Point(12, 9);
            this.lblfrm.Name = "lblfrm";
            this.lblfrm.Size = new System.Drawing.Size(104, 17);
            this.lblfrm.TabIndex = 8;
            this.lblfrm.Text = "Asignaciones";
            // 
            // dtgRolesUsr
            // 
            this.dtgRolesUsr.AllowUserToAddRows = false;
            this.dtgRolesUsr.AllowUserToDeleteRows = false;
            this.dtgRolesUsr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRolesUsr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgRolesUsr.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgRolesUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRolesUsr.Location = new System.Drawing.Point(211, 65);
            this.dtgRolesUsr.MultiSelect = false;
            this.dtgRolesUsr.Name = "dtgRolesUsr";
            this.dtgRolesUsr.Size = new System.Drawing.Size(885, 282);
            this.dtgRolesUsr.TabIndex = 9;
            // 
            // lblUsusario
            // 
            this.lblUsusario.AutoSize = true;
            this.lblUsusario.Location = new System.Drawing.Point(12, 140);
            this.lblUsusario.Name = "lblUsusario";
            this.lblUsusario.Size = new System.Drawing.Size(43, 13);
            this.lblUsusario.TabIndex = 10;
            this.lblUsusario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(15, 156);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(167, 21);
            this.cmbUsuario.TabIndex = 11;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged_1);
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(15, 109);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(167, 21);
            this.cmbFamilia.TabIndex = 12;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(12, 93);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(58, 13);
            this.lblFamilia.TabIndex = 13;
            this.lblFamilia.Text = "Familia Usr";
            // 
            // dtgRolesExtra
            // 
            this.dtgRolesExtra.AllowUserToOrderColumns = true;
            this.dtgRolesExtra.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgRolesExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRolesExtra.Location = new System.Drawing.Point(211, 380);
            this.dtgRolesExtra.Name = "dtgRolesExtra";
            this.dtgRolesExtra.Size = new System.Drawing.Size(885, 227);
            this.dtgRolesExtra.TabIndex = 14;
            // 
            // lblSinAsignar
            // 
            this.lblSinAsignar.AutoSize = true;
            this.lblSinAsignar.Location = new System.Drawing.Point(213, 356);
            this.lblSinAsignar.Name = "lblSinAsignar";
            this.lblSinAsignar.Size = new System.Drawing.Size(83, 13);
            this.lblSinAsignar.TabIndex = 16;
            this.lblSinAsignar.Text = "Grilla sin asingar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 334);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnIrMenu
            // 
            this.btnIrMenu.Location = new System.Drawing.Point(15, 534);
            this.btnIrMenu.Name = "btnIrMenu";
            this.btnIrMenu.Size = new System.Drawing.Size(75, 23);
            this.btnIrMenu.TabIndex = 18;
            this.btnIrMenu.Text = "Ir a Menu";
            this.btnIrMenu.UseVisualStyleBackColor = true;
            this.btnIrMenu.Click += new System.EventHandler(this.btnIrMenu_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(107, 334);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblMailUsuario
            // 
            this.lblMailUsuario.AutoSize = true;
            this.lblMailUsuario.Location = new System.Drawing.Point(17, 213);
            this.lblMailUsuario.Name = "lblMailUsuario";
            this.lblMailUsuario.Size = new System.Drawing.Size(72, 13);
            this.lblMailUsuario.TabIndex = 20;
            this.lblMailUsuario.Text = "lblMailUsuario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(443, 351);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAccionesRoles
            // 
            this.lblAccionesRoles.AutoSize = true;
            this.lblAccionesRoles.Location = new System.Drawing.Point(356, 356);
            this.lblAccionesRoles.Name = "lblAccionesRoles";
            this.lblAccionesRoles.Size = new System.Drawing.Size(84, 13);
            this.lblAccionesRoles.TabIndex = 23;
            this.lblAccionesRoles.Text = "Acciones Roles:";
            // 
            // lblUsuarioSelect
            // 
            this.lblUsuarioSelect.AutoSize = true;
            this.lblUsuarioSelect.Location = new System.Drawing.Point(17, 242);
            this.lblUsuarioSelect.Name = "lblUsuarioSelect";
            this.lblUsuarioSelect.Size = new System.Drawing.Size(53, 13);
            this.lblUsuarioSelect.TabIndex = 24;
            this.lblUsuarioSelect.Text = "lblUsuario";
            // 
            // lblUsuarioId
            // 
            this.lblUsuarioId.AutoSize = true;
            this.lblUsuarioId.Location = new System.Drawing.Point(117, 140);
            this.lblUsuarioId.Name = "lblUsuarioId";
            this.lblUsuarioId.Size = new System.Drawing.Size(62, 13);
            this.lblUsuarioId.TabIndex = 25;
            this.lblUsuarioId.Text = "lblUsuarioId";
            // 
            // RdbAlta
            // 
            this.RdbAlta.AutoSize = true;
            this.RdbAlta.Location = new System.Drawing.Point(12, 47);
            this.RdbAlta.Name = "RdbAlta";
            this.RdbAlta.Size = new System.Drawing.Size(88, 17);
            this.RdbAlta.TabIndex = 28;
            this.RdbAlta.TabStop = true;
            this.RdbAlta.Text = "Asignaciones";
            this.RdbAlta.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(17, 189);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(46, 13);
            this.lblGrupo.TabIndex = 31;
            this.lblGrupo.Text = "lblGrupo";
            // 
            // lblUsuarioDoc
            // 
            this.lblUsuarioDoc.AutoSize = true;
            this.lblUsuarioDoc.Location = new System.Drawing.Point(17, 267);
            this.lblUsuarioDoc.Name = "lblUsuarioDoc";
            this.lblUsuarioDoc.Size = new System.Drawing.Size(73, 13);
            this.lblUsuarioDoc.TabIndex = 32;
            this.lblUsuarioDoc.Text = "lblUsuarioDoc";
            // 
            // lblUsrId
            // 
            this.lblUsrId.AutoSize = true;
            this.lblUsrId.Location = new System.Drawing.Point(73, 140);
            this.lblUsrId.Name = "lblUsrId";
            this.lblUsrId.Size = new System.Drawing.Size(42, 13);
            this.lblUsrId.TabIndex = 33;
            this.lblUsrId.Text = "lblUsrId";
            // 
            // ChcCondicion
            // 
            this.ChcCondicion.AutoSize = true;
            this.ChcCondicion.Location = new System.Drawing.Point(12, 301);
            this.ChcCondicion.Name = "ChcCondicion";
            this.ChcCondicion.Size = new System.Drawing.Size(92, 17);
            this.ChcCondicion.TabIndex = 42;
            this.ChcCondicion.Text = "ChcCondicion";
            this.ChcCondicion.UseVisualStyleBackColor = true;
            // 
            // FrmAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 619);
            this.Controls.Add(this.ChcCondicion);
            this.Controls.Add(this.lblUsrId);
            this.Controls.Add(this.lblUsuarioDoc);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.RdbAlta);
            this.Controls.Add(this.lblUsuarioId);
            this.Controls.Add(this.lblUsuarioSelect);
            this.Controls.Add(this.lblAccionesRoles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMailUsuario);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnIrMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSinAsignar);
            this.Controls.Add(this.dtgRolesExtra);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblUsusario);
            this.Controls.Add(this.dtgRolesUsr);
            this.Controls.Add(this.lblfrm);
            this.Name = "FrmAsignaciones";
            this.Text = "frmAsignaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRolesUsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRolesExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrm;
        private System.Windows.Forms.DataGridView dtgRolesUsr;
        private System.Windows.Forms.Label lblUsusario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.DataGridView dtgRolesExtra;
        private System.Windows.Forms.Label lblSinAsignar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIrMenu;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblMailUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAccionesRoles;
        private System.Windows.Forms.Label lblUsuarioSelect;
        private System.Windows.Forms.Label lblUsuarioId;
        private System.Windows.Forms.RadioButton RdbAlta;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblUsuarioDoc;
        private System.Windows.Forms.Label lblUsrId;
        private System.Windows.Forms.CheckBox ChcCondicion;
    }
}