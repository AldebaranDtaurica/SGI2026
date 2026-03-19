using CapaLogica;
using System;
using System.Data;
using System.Windows.Forms;


namespace VistaSGI
{
    public partial class FrmRoles : Form
    {
        private readonly CL_Usuario usuario = new CL_Usuario();
        private readonly CL_AbmPerfiles abmPerfiles = new CL_AbmPerfiles();
        private readonly CapaLogica.Usuario.CL_Roles clRoles = new CapaLogica.Usuario.CL_Roles();
        DataTable dtAsignados;
        DataTable dtDisponibles;
        public FrmRoles()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            HideAllControlsExceptRadioButtons();
            rdbConsulta.CheckedChanged += rdbConsulta_CheckedChanged;
            rdbAsignarRoles.CheckedChanged += rdbAsignarRoles_CheckedChanged;
            CargarFamilia();
            CargarComboUsuarios();
            cmbUsuario.SelectedIndex = -1;
            cmbFamilia.SelectedIndex = -1;
        }

        private void HideAllControlsExceptRadioButtons()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl == rdbAsignarRoles || ctrl == rdbConsulta || ctrl == lblfrm || ctrl == btnIrMenu)
                {
                    ctrl.Visible = true;
                }
                else
                {
                    ctrl.Visible = false;
                }
            }
        }
        private void rdbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConsulta.Checked)
            {
                ApplyMode(true);
            }
        }
        private void rdbAsignarRoles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsignarRoles.Checked)
            {
                ApplyMode(false);
            }
        }

        private void ApplyMode(bool modoConsulta)
        {
            rdbConsulta.Visible = true;
            rdbAsignarRoles.Visible = true;
            lblfrm.Visible = true;
            btnIrMenu.Visible = true;
            dtgRolesUsr.Dock = DockStyle.Fill;
            dtgRolesUsr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRolesExtra.Dock = DockStyle.Fill;
            dtgRolesExtra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;


            if (modoConsulta)
            {
                lblRolesUsr.Visible = true;
                lblRolesUsr.Text = "Roles Familia";
                dtgRolesUsr.Visible = true;
                lblRolesExtra.Visible = false;
                dtgRolesExtra.Visible = false;
                lblFamilia.Visible = true;
                cmbFamilia.Refresh();
                cmbFamilia.Text = "";
                lblUsuarioDoc.Visible = false;
                cmbFamilia.Visible = true;
                btnCargar.Visible = false;
                btnBuscar.Visible = true;
                rdbConsulta.Enabled = false;
                rdbAsignarRoles.Enabled = true;
                lblUsusario.Visible = false;
                cmbUsuario.Visible = false;
                btnAgregar.Visible = false;
                btnQuitar.Visible = false;
                btnConfirmar.Visible = false;
                lblMailUsuario.Visible = false;
                lblUsuarioSelect.Visible = false;
                lblUsuarioId.Visible = false;
                lblAccionesRoles.Visible = false;
                dtgRolesUsr.DataSource = null;
                dtgRolesExtra.DataSource = null;
                dtgRolesUsr.AutoSize = true;
                dtgRolesExtra.AutoSize = true;
                lblGrupo.Visible = false;
                cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            else
            {
                dtgRolesUsr.DataSource = null;
                dtgRolesExtra.DataSource = null;
                cmbFamilia.Refresh();
                cmbFamilia.Text = "";
                dtgRolesUsr.Visible = false;
                //cmbUsuario.Text = "";
                lblUsuarioDoc.Visible = true;
                dtgRolesUsr.Refresh();
                dtgRolesExtra.Refresh();
                lblUsrId.Visible = true;
                lblUsrId.Text = "";
                rdbConsulta.Enabled = true;
                rdbAsignarRoles.Enabled = false;
                lblUsusario.Visible = true;
                cmbUsuario.Visible = true;
                lblFamilia.Visible = false;
                cmbFamilia.Visible = false;
                btnAgregar.Visible = true;
                lblGrupo.Visible = true;
                btnQuitar.Visible = true;
                btnConfirmar.Visible = true;
                lblMailUsuario.Visible = true;
                lblUsuarioSelect.Visible = true;
                lblUsuarioId.Visible = true;
                lblAccionesRoles.Visible = true;
                dtgRolesExtra.Visible = true;
                // Ocultar controles de solo consulta
                lblRolesUsr.Visible = true;
                dtgRolesUsr.Visible = true;
                btnCargar.Visible = true;
                btnBuscar.Visible = false;
                lblRolesExtra.Visible = true;
                lblGrupo.Text = "";
                lblMailUsuario.Text = "";
                lblUsuarioId.Text = "";
                lblUsuarioSelect.Text = "";
                lblUsuarioDoc.Text = "";
            }
        }

        public DataTable CargarFamilia()
        {
            CV_Model cargaBox = new CV_Model(cmbFamilia);
            DataTable dtFamilia = cargaBox.CargarFamilia();
            cmbFamilia.Items.Clear();

            for (int i = dtFamilia.Rows.Count - 1; i >= 0; i--)
            {
                string nombre = dtFamilia.Rows[i][1].ToString();
                if (nombre == "PARAMETROS" || nombre == "CONFIGURACIONES")
                {
                    dtFamilia.Rows.RemoveAt(i);
                }
            }
            foreach (DataRow row in dtFamilia.Rows)
            {
                cmbFamilia.Items.Add(row[1].ToString());
            }
            //dtFamilia.Clear();
            return dtFamilia;
        }


        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int CP_NOCLOSE_BUTTON = 0x200;
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgRolesUsr.DataSource = null;
            string familiaSeleccionada = cmbFamilia.SelectedItem?.ToString();
            dtgRolesUsr.DataSource = abmPerfiles.ConsultarFamiliaPermisos(familiaSeleccionada);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(lblUsuarioId.Text);

            clRoles.ConsultarRol(Id);
            dtgRolesExtra.ReadOnly = true;

            dtAsignados = clRoles.ConsultarRolActivo(Id);
            dtDisponibles = clRoles.ConsultarRolInactivo(Id);

            dtgRolesUsr.DataSource = dtAsignados;
            dtgRolesExtra.DataSource = dtDisponibles;

            dtgRolesUsr.ReadOnly = false;
            foreach (DataGridViewColumn col in dtgRolesUsr.Columns)
            {
                if (col.Name == "BajaProgramada")
                {
                    col.ReadOnly = false;
                    // Forzamos el formato visual dd-mm-yyyy
                    col.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                else
                {
                    col.ReadOnly = true;
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (dtgRolesExtra.CurrentRow == null) return;

            DataRowView filaSeleccionada = (DataRowView)dtgRolesExtra.CurrentRow.DataBoundItem;
            DataRow rowOriginal = filaSeleccionada.Row;

            DataRow nuevaFila = dtAsignados.NewRow();

            nuevaFila["IdRol"] = rowOriginal["IdRol"];
            nuevaFila["Rol"] = rowOriginal["Rol"];
            nuevaFila["Estado"] = true;
            nuevaFila["IdUsuario"] = Convert.ToInt32(lblUsrId.Text);
            nuevaFila["IdPersona"] = Convert.ToInt32(lblUsuarioId.Text);
            nuevaFila["BajaProgramada"] = DBNull.Value;

            // 3. Ejecutar el movimiento
            dtAsignados.Rows.Add(nuevaFila);
            rowOriginal.Delete();

            dtDisponibles.AcceptChanges();
        }

        public void CargarComboUsuarios()
        {
            DataTable dt = usuario.ConsultarUsuarios();
            cmbUsuario.DataSource = dt;
            cmbUsuario.DisplayMember = "Usuario";
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex != -1)
            {
                dtgRolesUsr.DataSource = null;
                dtgRolesExtra.DataSource = null;
                // 2. Obtenemos la fila completa vinculada al elemento seleccionado
                DataRowView filaSeleccionada = (DataRowView)cmbUsuario.SelectedItem;
                lblGrupo.Text = filaSeleccionada["Grupo"].ToString();
                lblMailUsuario.Text = filaSeleccionada["Email"].ToString();
                lblUsuarioId.Text = filaSeleccionada["IdPersona"].ToString();
                lblUsuarioSelect.Text = filaSeleccionada["ApeNom"].ToString();
                lblUsuarioDoc.Text = filaSeleccionada["TipoNumDoc"].ToString();
                int IdUsr = usuario.ConsultarUsuarioId(Convert.ToInt32(lblUsuarioId.Text));
                lblUsrId.Text = IdUsr.ToString();
            }
        }

        private void dtgRolesUsr_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgRolesUsr.Columns[e.ColumnIndex].Name == "BajaProgramada")
            {
                // Si quieres validar que sea una fecha actual-futura:
                var valor = dtgRolesUsr.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (valor != DBNull.Value && Convert.ToDateTime(valor).Date < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de baja debe ser igual o mayor a la fecha actual.");
                    dtgRolesUsr.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                }
            }
        }

        private void dtgRolesUsr_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dtgRolesUsr.Columns[e.ColumnIndex].Name == "BajaProgramada")
            {
                string input = e.FormattedValue.ToString();
                if (!string.IsNullOrEmpty(input))
                {
                    DateTime tempDate;
                    if (!DateTime.TryParse(input, out tempDate))
                    {
                        e.Cancel = true; // Bloquea la salida de la celda
                        MessageBox.Show("Formato de fecha no válido. Use: dd/mm/yyyy", "Error de formato");
                    }
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtAsignados == null || string.IsNullOrEmpty(lblUsuarioId.Text)) return;

                int idUser = Convert.ToInt32(lblUsrId.Text);

                // Llamamos al nuevo método de la lógica
                bool exito = clRoles.GuardarConfiguracionRoles(dtAsignados, idUser);

                if (exito)
                {
                    MessageBox.Show("Configuración de roles guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Recargar los datos para limpiar estados de edición
                    btnCargar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

