namespace VistaSGI
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnLustaUsr = new System.Windows.Forms.Button();
            this.btnAltaUsr = new System.Windows.Forms.Button();
            this.btnBajaUsr = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnIrMenu = new System.Windows.Forms.Button();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.Baja_Usr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar_Usr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarUsr = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            resources.ApplyResources(this.btnRoles, "btnRoles");
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnLustaUsr
            // 
            resources.ApplyResources(this.btnLustaUsr, "btnLustaUsr");
            this.btnLustaUsr.Name = "btnLustaUsr";
            this.btnLustaUsr.UseVisualStyleBackColor = true;
            this.btnLustaUsr.Click += new System.EventHandler(this.btnLustaUsr_Click);
            // 
            // btnAltaUsr
            // 
            resources.ApplyResources(this.btnAltaUsr, "btnAltaUsr");
            this.btnAltaUsr.Name = "btnAltaUsr";
            this.btnAltaUsr.UseVisualStyleBackColor = true;
            this.btnAltaUsr.Click += new System.EventHandler(this.btnAltaUsr_Click);
            // 
            // btnBajaUsr
            // 
            resources.ApplyResources(this.btnBajaUsr, "btnBajaUsr");
            this.btnBajaUsr.Name = "btnBajaUsr";
            this.btnBajaUsr.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnIrMenu
            // 
            resources.ApplyResources(this.btnIrMenu, "btnIrMenu");
            this.btnIrMenu.Name = "btnIrMenu";
            this.btnIrMenu.UseVisualStyleBackColor = true;
            this.btnIrMenu.Click += new System.EventHandler(this.btnIrMenu_Click);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baja_Usr,
            this.Modificar_Usr});
            resources.ApplyResources(this.dtgUsuarios, "dtgUsuarios");
            this.dtgUsuarios.MultiSelect = false;
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
            // 
            // Baja_Usr
            // 
            this.Baja_Usr.Frozen = true;
            resources.ApplyResources(this.Baja_Usr, "Baja_Usr");
            this.Baja_Usr.Name = "Baja_Usr";
            this.Baja_Usr.ReadOnly = true;
            this.Baja_Usr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Baja_Usr.Text = "Dar de Baja";
            // 
            // Modificar_Usr
            // 
            this.Modificar_Usr.Frozen = true;
            resources.ApplyResources(this.Modificar_Usr, "Modificar_Usr");
            this.Modificar_Usr.Name = "Modificar_Usr";
            this.Modificar_Usr.ReadOnly = true;
            this.Modificar_Usr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar_Usr.Text = "Modificar";
            // 
            // btnBuscarUsr
            // 
            resources.ApplyResources(this.btnBuscarUsr, "btnBuscarUsr");
            this.btnBuscarUsr.Name = "btnBuscarUsr";
            this.btnBuscarUsr.UseVisualStyleBackColor = true;
            this.btnBuscarUsr.Click += new System.EventHandler(this.btnBuscarUsr_Click);
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ControlBox = false;
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscarUsr);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.btnIrMenu);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBajaUsr);
            this.Controls.Add(this.btnAltaUsr);
            this.Controls.Add(this.btnLustaUsr);
            this.Controls.Add(this.btnRoles);
            this.Name = "FrmUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnLustaUsr;
        private System.Windows.Forms.Button btnAltaUsr;
        private System.Windows.Forms.Button btnBajaUsr;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnIrMenu;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btnBuscarUsr;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn Baja_Usr;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar_Usr;
    }
}