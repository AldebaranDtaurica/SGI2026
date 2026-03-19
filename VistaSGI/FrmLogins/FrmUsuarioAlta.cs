using CapaLogica;
using System;
using System.Data;
using System.Windows.Forms;
//using VistaSGI.FrmLogin;

namespace VistaSGI
{
    public partial class FrmUsuarioAlta : Form
    {
        private readonly CL_Usuario usuario = new CL_Usuario();
        private readonly CL_IngresoDatos IngresoDatos = new CL_IngresoDatos();
        private readonly CL_CargaBox clBoxCarga = new CL_CargaBox();
        private readonly CL_UsuarioPermiso permisoUsuario = new CL_UsuarioPermiso();

        public FrmUsuarioAlta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            CargarGrupos();
            CV_Model cargaBox = new CV_Model(cmbFamilia);
            DataTable dtFamilia = cargaBox.CargarFamilia();
            DataTable dtTipoDocumento = CargarTipoDocumento();
            cmbFamilia.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string grupoSeleccionado = cmbGrupo.SelectedItem?.ToString();
            string familiaCalculada = CalcularFamiliaDesdeGrupo(grupoSeleccionado);
            string tipoNumeroDoc = cmbTipoDocumento.SelectedItem?.ToString() + " - " + txtDocumento.Text;
            if (txtApellido.Text == "" || txtNombre.Text == "" || cmbTipoDocumento.Text == "" || txtDocumento.Text == "" || txtEmail.Text == "" || cmbGrupo.Text == "" || cmbFamilia.Text == "" || txtNombreUsr.Text == "" || nmrDias.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            if (usuario.ExisteUsuario(txtNombreUsr.Text, tipoNumeroDoc))
            {
                MessageBox.Show("El nombre de usuario ya existe (o el documento ya fue ingresado). Por favor, elija otro ususario, si el problema persiste hable con el administrador del ISFT172.");
                return;
            }
            try
            {
                CL_Usuario usuario = new CL_Usuario
                {
                    Apellido = txtApellido.Text.ToUpper(),
                    Nombre = txtNombre.Text.ToUpper(),
                    TipoDocumento = cmbTipoDocumento.SelectedItem?.ToString(),
                    NumeroDocumento = txtDocumento.Text,
                    Email = txtEmail.Text.ToUpper(),
                    Grupo = cmbGrupo.SelectedItem?.ToString(),
                    Familia = familiaCalculada,
                    Username = txtNombreUsr.Text,
                    DiasCambioClave = (int)nmrDias.Value
                };

                // Intentar guardar el usuario
                usuario.GuardarUsuario(usuario);
                MessageBox.Show("Usuario guardado correctamente");

                if (usuario.ComprobarFamiliaUsuario(familiaCalculada))
                {
                    bool alta = true;
                    // Asignar permisos específicos para Preceptores y Profesores
                    FrmAsignaciones frmAsignaciones = new FrmAsignaciones(familiaCalculada, txtNombreUsr.Text, alta);
                    _ = frmAsignaciones.ShowDialog(this);
                }
                //LimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                // Captura de excepciones de validación y muestra un mensaje de error
                MessageBox.Show("Error: " + ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Mostrar detalles del error
                string errorDetails = "Ocurrió un error inesperado: " + ex.ToString();
                if (ex.InnerException != null)
                {
                    errorDetails += "\n\nExcepción interna: " + ex.InnerException.ToString();
                }

                MessageBox.Show(errorDetails, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalcularFamiliaDesdeGrupo(string grupo)
        {
            if (string.IsNullOrEmpty(grupo))
                return null;

            // Ejemplo de mapeo. Ajustar según reglas reales.
            switch (grupo)
            {
                case "Administrador_a":
                    return "SISTEMAS";
                case "Director_a":
                    return "DIRECCION";
                case "Secretario_a":
                    return "SECRETARIA";
                case "Preceptor_a":
                    return "PRECEPTORES";
                case "Profesor_a":
                    return "PROFESORES";
                case "Alumno_a":
                    return "ALUMNOS";
                case "Postulante_Alumno":
                    return "ALUMNOS";
                default:
                    return null;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            // Guardamos la posición actual del cursor; método que filtra + convierte el texto
            int cursorPosition = txtApellido.SelectionStart;
            txtApellido.Text = IngresoDatos.FiltrarTextoYConvertirAMayusculas(txtApellido.Text);
            // Restauramos la posición del cursor
            txtApellido.SelectionStart = cursorPosition;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtNombre.SelectionStart;
            txtNombre.Text = IngresoDatos.FiltrarTextoYConvertirAMayusculas(txtNombre.Text);
            txtNombre.SelectionStart = cursorPosition;
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtDocumento.SelectionStart;
            txtDocumento.Text = IngresoDatos.FiltrarSoloNumeros(txtDocumento.Text);
            txtDocumento.SelectionStart = cursorPosition;
        }

        private void txtNombreUsr_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtNombreUsr.SelectionStart;
            txtNombreUsr.TextChanged -= txtNombreUsr_TextChanged;
            txtNombreUsr.Text = IngresoDatos.TextoNumerosMayusculas(txtNombreUsr.Text);
            txtNombreUsr.SelectionStart = cursorPosition;
            txtNombreUsr.TextChanged += txtNombreUsr_TextChanged;
        }

        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignarCursada_Click(object sender, EventArgs e)
        {

            DataTable datos = ConsultarUsuarios();
            //dataGridView1.DataSource = datos;

        }

        public DataTable ConsultarUsuarios()
        {
            CL_UsuarioPermiso permisoUsuario = new CL_UsuarioPermiso();
            return permisoUsuario.ObtenerPermisos();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarGrupos()
        {
            DataTable dtGrupos = clBoxCarga.BoxPersGrupo(); //cmbGrupo.Items.Clear();
            // Recorrer las filas del DataTable y agregar los elementos al ComboBox
            foreach (DataRow row in dtGrupos.Rows)
            {
                cmbGrupo.Items.Add(row[1].ToString());
            }
            if (cmbGrupo.Items.Count > 0) // Opcionalmente, PODRIAMOS establecer un valor por defecto
            { cmbGrupo.SelectedIndex = 0; }
        }

        private DataTable CargarTipoDocumento()
        {
            DataTable dtTipoDocumento = clBoxCarga.BoxTipoDoc();
            foreach (DataRow row in dtTipoDocumento.Rows)
            {
                cmbTipoDocumento.Items.Add(row[1].ToString());
            }
            if (cmbTipoDocumento.Items.Count > 0)
            { cmbTipoDocumento.SelectedIndex = 0; }
            return dtTipoDocumento;
        }

        private void CmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grupo = cmbGrupo.SelectedItem?.ToString();
            string familia = CalcularFamiliaDesdeGrupo(grupo);

            if (string.IsNullOrEmpty(familia))
                return;

            cmbFamilia.Text = familia;
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


    }
}




