namespace VistaSGI
{
    partial class FrmRoles
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
            this.lblRolesUsr = new System.Windows.Forms.Label();
            this.lblRolesExtra = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnIrMenu = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblMailUsuario = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblAccionesRoles = new System.Windows.Forms.Label();
            this.lblUsuarioSelect = new System.Windows.Forms.Label();
            this.lblUsuarioId = new System.Windows.Forms.Label();
            this.rdbConsulta = new System.Windows.Forms.RadioButton();
            this.rdbAsignarRoles = new System.Windows.Forms.RadioButton();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblUsuarioDoc = new System.Windows.Forms.Label();
            this.lblUsrId = new System.Windows.Forms.Label();
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
            this.lblfrm.Size = new System.Drawing.Size(80, 17);
            this.lblfrm.TabIndex = 8;
            this.lblfrm.Text = "Roles SGI";
            // 
            // dtgRolesUsr
            // 
            this.dtgRolesUsr.AllowUserToAddRows = false;
            this.dtgRolesUsr.AllowUserToDeleteRows = false;
            this.dtgRolesUsr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRolesUsr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgRolesUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRolesUsr.Location = new System.Drawing.Point(211, 65);
            this.dtgRolesUsr.MultiSelect = false;
            this.dtgRolesUsr.Name = "dtgRolesUsr";
            this.dtgRolesUsr.ReadOnly = true;
            this.dtgRolesUsr.Size = new System.Drawing.Size(459, 417);
            this.dtgRolesUsr.TabIndex = 9;
            this.dtgRolesUsr.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRolesUsr_CellEndEdit);
            this.dtgRolesUsr.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgRolesUsr_CellValidating);
            // 
            // lblUsusario
            // 
            this.lblUsusario.AutoSize = true;
            this.lblUsusario.Location = new System.Drawing.Point(15, 166);
            this.lblUsusario.Name = "lblUsusario";
            this.lblUsusario.Size = new System.Drawing.Size(43, 13);
            this.lblUsusario.TabIndex = 10;
            this.lblUsusario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(18, 182);
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
            this.dtgRolesExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRolesExtra.Location = new System.Drawing.Point(676, 65);
            this.dtgRolesExtra.Name = "dtgRolesExtra";
            this.dtgRolesExtra.Size = new System.Drawing.Size(431, 417);
            this.dtgRolesExtra.TabIndex = 14;
            // 
            // lblRolesUsr
            // 
            this.lblRolesUsr.AutoSize = true;
            this.lblRolesUsr.Location = new System.Drawing.Point(208, 49);
            this.lblRolesUsr.Name = "lblRolesUsr";
            this.lblRolesUsr.Size = new System.Drawing.Size(73, 13);
            this.lblRolesUsr.TabIndex = 15;
            this.lblRolesUsr.Text = "Roles Usuario";
            // 
            // lblRolesExtra
            // 
            this.lblRolesExtra.AutoSize = true;
            this.lblRolesExtra.Location = new System.Drawing.Point(673, 49);
            this.lblRolesExtra.Name = "lblRolesExtra";
            this.lblRolesExtra.Size = new System.Drawing.Size(66, 13);
            this.lblRolesExtra.TabIndex = 16;
            this.lblRolesExtra.Text = "Roles Extras";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnIrMenu
            // 
            this.btnIrMenu.Location = new System.Drawing.Point(15, 504);
            this.btnIrMenu.Name = "btnIrMenu";
            this.btnIrMenu.Size = new System.Drawing.Size(75, 23);
            this.btnIrMenu.TabIndex = 18;
            this.btnIrMenu.Text = "Ir a Menu";
            this.btnIrMenu.UseVisualStyleBackColor = true;
            this.btnIrMenu.Click += new System.EventHandler(this.btnIrMenu_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(15, 459);
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
            this.lblMailUsuario.Location = new System.Drawing.Point(20, 239);
            this.lblMailUsuario.Name = "lblMailUsuario";
            this.lblMailUsuario.Size = new System.Drawing.Size(72, 13);
            this.lblMailUsuario.TabIndex = 20;
            this.lblMailUsuario.Text = "lblMailUsuario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(110, 370);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 22;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // lblAccionesRoles
            // 
            this.lblAccionesRoles.AutoSize = true;
            this.lblAccionesRoles.Location = new System.Drawing.Point(15, 354);
            this.lblAccionesRoles.Name = "lblAccionesRoles";
            this.lblAccionesRoles.Size = new System.Drawing.Size(81, 13);
            this.lblAccionesRoles.TabIndex = 23;
            this.lblAccionesRoles.Text = "Acciones Roles";
            // 
            // lblUsuarioSelect
            // 
            this.lblUsuarioSelect.AutoSize = true;
            this.lblUsuarioSelect.Location = new System.Drawing.Point(20, 268);
            this.lblUsuarioSelect.Name = "lblUsuarioSelect";
            this.lblUsuarioSelect.Size = new System.Drawing.Size(53, 13);
            this.lblUsuarioSelect.TabIndex = 24;
            this.lblUsuarioSelect.Text = "lblUsuario";
            // 
            // lblUsuarioId
            // 
            this.lblUsuarioId.AutoSize = true;
            this.lblUsuarioId.Location = new System.Drawing.Point(120, 166);
            this.lblUsuarioId.Name = "lblUsuarioId";
            this.lblUsuarioId.Size = new System.Drawing.Size(62, 13);
            this.lblUsuarioId.TabIndex = 25;
            this.lblUsuarioId.Text = "lblUsuarioId";
            // 
            // rdbConsulta
            // 
            this.rdbConsulta.AutoSize = true;
            this.rdbConsulta.Location = new System.Drawing.Point(12, 47);
            this.rdbConsulta.Name = "rdbConsulta";
            this.rdbConsulta.Size = new System.Drawing.Size(147, 17);
            this.rdbConsulta.TabIndex = 28;
            this.rdbConsulta.TabStop = true;
            this.rdbConsulta.Text = "Consultar Familias y Roles";
            this.rdbConsulta.UseVisualStyleBackColor = true;
            // 
            // rdbAsignarRoles
            // 
            this.rdbAsignarRoles.AutoSize = true;
            this.rdbAsignarRoles.Location = new System.Drawing.Point(12, 65);
            this.rdbAsignarRoles.Name = "rdbAsignarRoles";
            this.rdbAsignarRoles.Size = new System.Drawing.Size(90, 17);
            this.rdbAsignarRoles.TabIndex = 29;
            this.rdbAsignarRoles.TabStop = true;
            this.rdbAsignarRoles.Text = "Asignar Roles";
            this.rdbAsignarRoles.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(15, 320);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 30;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(20, 215);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(46, 13);
            this.lblGrupo.TabIndex = 31;
            this.lblGrupo.Text = "lblGrupo";
            // 
            // lblUsuarioDoc
            // 
            this.lblUsuarioDoc.AutoSize = true;
            this.lblUsuarioDoc.Location = new System.Drawing.Point(20, 293);
            this.lblUsuarioDoc.Name = "lblUsuarioDoc";
            this.lblUsuarioDoc.Size = new System.Drawing.Size(73, 13);
            this.lblUsuarioDoc.TabIndex = 32;
            this.lblUsuarioDoc.Text = "lblUsuarioDoc";
            // 
            // lblUsrId
            // 
            this.lblUsrId.AutoSize = true;
            this.lblUsrId.Location = new System.Drawing.Point(76, 166);
            this.lblUsrId.Name = "lblUsrId";
            this.lblUsrId.Size = new System.Drawing.Size(42, 13);
            this.lblUsrId.TabIndex = 33;
            this.lblUsrId.Text = "lblUsrId";
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 563);
            this.Controls.Add(this.lblUsrId);
            this.Controls.Add(this.lblUsuarioDoc);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.rdbAsignarRoles);
            this.Controls.Add(this.rdbConsulta);
            this.Controls.Add(this.lblUsuarioId);
            this.Controls.Add(this.lblUsuarioSelect);
            this.Controls.Add(this.lblAccionesRoles);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMailUsuario);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnIrMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRolesExtra);
            this.Controls.Add(this.lblRolesUsr);
            this.Controls.Add(this.dtgRolesExtra);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblUsusario);
            this.Controls.Add(this.dtgRolesUsr);
            this.Controls.Add(this.lblfrm);
            this.Name = "FrmRoles";
            this.Text = "frmRoles";
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
        private System.Windows.Forms.Label lblRolesUsr;
        private System.Windows.Forms.Label lblRolesExtra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIrMenu;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblMailUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblAccionesRoles;
        private System.Windows.Forms.Label lblUsuarioSelect;
        private System.Windows.Forms.Label lblUsuarioId;
        private System.Windows.Forms.RadioButton rdbConsulta;
        private System.Windows.Forms.RadioButton rdbAsignarRoles;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblUsuarioDoc;
        private System.Windows.Forms.Label lblUsrId;
    }
}