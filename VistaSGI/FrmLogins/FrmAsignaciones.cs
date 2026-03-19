using CapaLogica;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace VistaSGI
{
    public partial class FrmAsignaciones : Form
    {
        private readonly CL_Usuario usuario = new CL_Usuario();
        private readonly CL_AbmPerfiles abmPerfiles = new CL_AbmPerfiles();
        private readonly CapaLogica.Usuario.CL_Roles clRoles = new CapaLogica.Usuario.CL_Roles();
        DataTable dtAsignados;
        DataTable dtDisponibles;
        public FrmAsignaciones(string familia = "", string usuariox = "", bool alta = false)
        //public FrmAsignaciones(string familia = "", string usuariox = "", bool alta = false)
        {
            InitializeComponent();
            ChcCondicion.Visible = false; //Preparado para futuras implementaciones, actualmente no se utiliza en la lógica.
                                          //Boleano de profesor responsabe de cátedra o preceptor principal.
            this.StartPosition = FormStartPosition.CenterScreen;
            HideAllControlsExceptRadioButtons(familia, usuariox, alta);
            dtgRolesUsr.Visible = true;
            dtgRolesExtra.Visible = true;
            if (alta == true)
                { 
            dtgRolesUsr.DataSource = usuario.AsignacionProfesorPreceptor(usuariox, familia, true);
            dtgRolesExtra.DataSource = usuario.AsignacionProfesorPreceptor(usuariox, familia, false);
            }
            ApplyMode(true);
            RdbAlta.CheckedChanged += rdbConsulta_CheckedChanged;
            dtgRolesUsr.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgRolesExtra.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgRolesUsr.CellContentClick += DtRolesUsr_CellContentClick;
            dtgRolesExtra.CellContentClick += DtRolesExtra_CellContentClick;
        }

        private void HideAllControlsExceptRadioButtons(string familia = "", string usuariox = "", bool alta = false)
        {
            if (alta == true)
            {   
                btnIrMenu.Enabled = true;
                RdbAlta.Checked = true;
                cmbFamilia.Enabled = false;
                cmbUsuario.Enabled = false;
                CargarFamilia(familia);
                CargarComboUsuarios(usuariox);
                cmbUsuario_SelectedIndexChanged_1(cmbUsuario, EventArgs.Empty);
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != btnConfirmar || ctrl != ChcCondicion)
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
            if (RdbAlta.Checked)
            {
                ApplyMode(true);
            } 
        }

        private void ApplyMode(bool modoConsulta)
        {
            dtgRolesExtra.ReadOnly = false;
            dtgRolesUsr.ReadOnly = false;
            RdbAlta.Visible = true;
            lblfrm.Visible = true;
            //btnIrMenu.Enabled = true;
            dtgRolesUsr.Dock = DockStyle.Fill;
            dtgRolesUsr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRolesExtra.Dock = DockStyle.Fill;
            dtgRolesExtra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgRolesExtra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgRolesExtra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgRolesExtra.Font = new Font("Microsoft Sans Serif", 7);
            if (modoConsulta)
            {
                cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            else
            {
                btnIrMenu.Enabled = true;
            }
        }

        public DataTable CargarFamilia(string familia)
        {
            CV_Model cargaBox = new CV_Model(cmbFamilia);
            DataTable dtFamilia = cargaBox.CargarFamilia();

            if (!string.IsNullOrEmpty(familia))
            {
                DataRow[] filas = dtFamilia.Select("Fdescripcion = '" + familia + "'");
                if (filas.Length > 0)
                {
                    DataTable dtFiltrado = filas.CopyToDataTable();
                    cmbFamilia.DataSource = dtFiltrado;
                    cmbFamilia.DisplayMember = "Fdescripcion"; // Nombre de la columna, no la variable
                    //cmbFamilia.SelectedItem = familia;
                    return dtFiltrado;
                }
            }
            for (int i = dtFamilia.Rows.Count - 1; i >= 0; i--)
            {
                string nombre = dtFamilia.Rows[i]["Fdescripcion"].ToString();
                if (nombre != "PRECEPTORES" && nombre != "PROFESORES")
                {
                    dtFamilia.Rows.RemoveAt(i);
                }
            }
            cmbFamilia.DataSource = dtFamilia;
            cmbFamilia.DisplayMember = "Fdescripcion";
            return dtFamilia;
        }


        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex == -1 || cmbFamilia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un usuario y una familia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtgRolesUsr.DataSource = null;
            dtgRolesExtra.DataSource = null;
            dtgRolesUsr.DataSource = usuario.AsignacionProfesorPreceptor(cmbUsuario.Text, cmbFamilia.Text, true);
            dtgRolesExtra.DataSource = usuario.AsignacionProfesorPreceptor(cmbUsuario.Text, cmbFamilia.Text, false);
        }

        private void DtRolesUsr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridViewColumn clickedColumn = dtgRolesUsr.Columns[e.ColumnIndex];
            if (clickedColumn == null || clickedColumn.Name != "Asignado")
            {
                return;
            }
            object source = dtgRolesUsr.DataSource;
            if (source == null || !(source is DataTable))
            {
                return;
            }
            DataTable dt = (DataTable)source;
            if (dt.Columns.Contains("Asignado"))
            {
                DataColumn dc = dt.Columns["Asignado"];
                if (dc.ReadOnly)
                {
                    dc.ReadOnly = false;
                }
            }   
            else
            {
                return;
            }
            object dataBoundItem = dtgRolesUsr.Rows[e.RowIndex].DataBoundItem;
            if (!(dataBoundItem is DataRowView))
            {
                return;
            }
            DataRowView drv = (DataRowView)dataBoundItem;
            DataRow row = drv.Row;

            bool valorActual = false;
            if (row.Table.Columns.Contains("Asignado") && row["Asignado"] != DBNull.Value && row["Asignado"] != null)
            {
                try
                {
                    valorActual = Convert.ToBoolean(row["Asignado"]);
                }
                catch
                {
                    valorActual = false;
                }
            }
            row["Asignado"] = !valorActual;
        }

        private void DtRolesExtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var col = dtgRolesExtra.Columns[e.ColumnIndex];
            if (col.Name == "")
            {
                // Alternar checkbox manualmente y confirmar el cambio
                var cell = dtgRolesExtra.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool actual = Convert.ToBoolean(cell.Value == null ? false : cell.Value);
                cell.Value = !actual;
                dtgRolesExtra.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string familia = cmbFamilia.Text;
            dtAsignados = null;
            dtAsignados = dtgRolesUsr.DataSource as DataTable;
            if (dtgRolesExtra.CurrentRow == null) return;

            if (dtAsignados == null)
            {
                dtAsignados = dtgRolesUsr.DataSource as DataTable;
                if (dtAsignados == null)
                {
                    MessageBox.Show("No se lograron cargar los componentes visuales.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DataRowView filaSeleccionada = (DataRowView)dtgRolesExtra.CurrentRow.DataBoundItem;
            DataRow rowOriginal = filaSeleccionada.Row;
            DataRow nuevaFila = dtAsignados.NewRow();

            if (familia == "PRECEPTORES")
            {
                nuevaFila["IdCarreraDivision"] = rowOriginal["IdCarreraDivision"];
                nuevaFila["Carrera"] = rowOriginal["Carrera"];
                nuevaFila["Año"] = rowOriginal["Año"];
                nuevaFila["Division"] = rowOriginal["Division"];
                nuevaFila["Asignado"] = true;
            }
            else if (familia == "PROFESORES")
            {
                nuevaFila["IdMateria"] = rowOriginal["IdMateria"];
                nuevaFila["Carrera"] = rowOriginal["Carrera"];
                nuevaFila["Materia"] = rowOriginal["Materia"];
                nuevaFila["Año"] = rowOriginal["Año"];
                nuevaFila["Division"] = rowOriginal["Division"];
                nuevaFila["Asignado"] = true;
            }
            else
            {
                MessageBox.Show("Familia desconocida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtAsignados.Rows.Add(nuevaFila);
            rowOriginal.Delete();
            dtDisponibles?.AcceptChanges();
            btnConfirmar.Visible = (dtgRolesUsr.RowCount > 0);
        }

        public void CargarComboUsuarios(string usuariob)
        {
            DataTable dt = usuario.ConsultarUsuarios();
            DataView dv = new DataView(dt);

            if (!string.IsNullOrEmpty(usuariob))
            {
                dv.RowFilter = "Usuario = '" + usuariob + "'";
            }
            cmbUsuario.DataSource = dv;
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
                btnConfirmar.Visible = (dtgRolesUsr.RowCount > 0);
            }
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Validate();
            dtgRolesUsr.EndEdit();
            try
            {
                if (dtAsignados == null || string.IsNullOrEmpty(lblUsuarioId.Text)) return;

                int idPersona = Convert.ToInt32(lblUsuarioId.Text);
                bool condicion = ChcCondicion.Checked;
                bool exito = clRoles.GuardarAsignacionesPP(dtAsignados, idPersona, cmbFamilia.Text, condicion);

                if (exito)
                {
                    MessageBox.Show("Configuración de asignaciones guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Recargar los datos para limpiar estados de edición
                    //btnCargar_Click(null, null);
                    btnIrMenu.Enabled = true;
                    dtgRolesUsr.DataSource = null;
                    dtgRolesExtra.DataSource = null;
                    dtgRolesUsr.DataSource = usuario.AsignacionProfesorPreceptor(cmbUsuario.Text, cmbFamilia.Text, true);
                    dtgRolesExtra.DataSource = usuario.AsignacionProfesorPreceptor(cmbUsuario.Text, cmbFamilia.Text, false);
                    dtAsignados = null;
                    dtAsignados = dtgRolesUsr.DataSource as DataTable;
                    dtDisponibles = null;
                    dtDisponibles = dtgRolesExtra.DataSource as DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFamilia.SelectedIndex != -1 && cmbFamilia.DataSource != null)
            {
                string familiaSeleccionada = cmbFamilia.GetItemText(cmbFamilia.SelectedItem);
                DataTable dtUsuariosFiltrados = usuario.ConsultarUsuarios(familiaSeleccionada);
                cmbUsuario.DataSource = dtUsuariosFiltrados;
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.ValueMember = "IdPersona";
                cmbUsuario.SelectedIndex = -1;
            }
        }
    }
}

