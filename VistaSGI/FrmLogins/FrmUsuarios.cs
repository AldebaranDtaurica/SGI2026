using System;
using System.Data;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmUsuarios : Form
    {
        private static FrmUsuarios instancia = null;
        public static FrmUsuarios ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmUsuarios();
                return instancia;
            }
            return instancia;
        }

        public FrmUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dtgUsuarios.DataSource = null;
            dtgUsuarios.Dock = DockStyle.Fill;
            dtgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarios.CellFormatting += dtgUsuarios_CellFormatting;
            btnLustaUsr_Click(this, EventArgs.Empty);
        }

        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAltaUsr_Click(object sender, EventArgs e)
        {
            FrmUsuarioAlta frmUsuarioAlta = new FrmUsuarioAlta();
            frmUsuarioAlta.ShowDialog(this);
        }

        private void btnBuscarUsr_Click(object sender, EventArgs e)
        {

        }

        private void btnLustaUsr_Click(object sender, EventArgs e)
        {
            dtgUsuarios.Columns.Clear();
            dtgUsuarios.DataSource = null;
            CapaLogica.CL_Usuario clUsuario = new CapaLogica.CL_Usuario();

            // Consulta los usuarios
            DataTable dtUsuarios = clUsuario.ConsultarUsuarios();

            // Columna de botón para Modificar
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn()
            {
                Name = "Modificar",
                HeaderText = "Modificar",
                Text = "Modificar",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            // Columna de botón para Baja
            DataGridViewButtonColumn btnBaja = new DataGridViewButtonColumn()
            {
                Name = "Baja",
                HeaderText = "Baja",
                Text = "Baja",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            DataGridViewButtonColumn btnAsignar = new DataGridViewButtonColumn()
            {
                Name = "Asignar",
                HeaderText = "Asignar",
                Text = "Asignar",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            dtgUsuarios.DataSource = dtUsuarios;
            dtgUsuarios.Columns.Add(btnModificar);
            dtgUsuarios.Columns.Add(btnBaja);
            dtgUsuarios.Columns.Add(btnAsignar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dtgUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgUsuarios.Columns[e.ColumnIndex].Name == "Asignar" && e.RowIndex >= 0)
            {
                string perfil = dtgUsuarios.Rows[e.RowIndex].Cells["Perfil"].Value?.ToString();

                if (perfil != "PROFESORES" && perfil != "PRECEPTORES")
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                    e.CellStyle.BackColor = System.Drawing.Color.DarkGray;
                    e.CellStyle.ForeColor = System.Drawing.Color.DarkGray;
                }
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

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dtgUsuarios.Columns[e.ColumnIndex].Name == "Asignar")
            {
                string perfil = dtgUsuarios.Rows[e.RowIndex].Cells["Perfil"].Value?.ToString();
                string usuario = dtgUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value?.ToString();
                bool alta = false;

                // Validar perfil permitido
                if (perfil != "PROFESORES" && perfil != "PRECEPTORES")
                    return;

                // Crear formulario pasando parámetros
                FrmAsignaciones frm = new FrmAsignaciones(perfil, usuario, true);
                frm.ShowDialog(this);
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles FrmRoles = new FrmRoles();
            _ = FrmRoles.ShowDialog(this);
        }
    }
}
