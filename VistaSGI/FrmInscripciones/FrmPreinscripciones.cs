using CapaLogica;
using System;
using System.Data;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmPreinscripciones : Form
    {
        CL_Usuario usuario = new CL_Usuario();
        CL_IngresoDatos IngresoDatos = new CL_IngresoDatos();
        CL_CargaBox clBoxCarga = new CL_CargaBox();


        public FrmPreinscripciones()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarGrupos();
            CV_Model cargaBox = new CV_Model(cmbFamilia);
            DataTable dtFamilia = cargaBox.CargarFamilia();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || cmbTipoDocumento.Text == "" || txtDocumento.Text == "" || txtEmail.Text == "" || cmbGrupo.Text == "" || cmbFamilia.Text == "" || txtNombreUsr.Text == "" || nmrDias.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
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
                    Familia = cmbFamilia.SelectedItem?.ToString(),
                    Username = txtNombreUsr.Text,
                    DiasCambioClave = (int)nmrDias.Value
                };

                // Intentar guardar el usuario
                usuario.GuardarUsuario(usuario);
                MessageBox.Show("Usuario guardado correctamente");
                //LimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                // Captura de excepciones de validación y muestra un mensaje de error
                MessageBox.Show("Error: " + ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura de cualquier otra excepción y muestra un mensaje genérico
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Deshabilitamos temporalmente el evento TextChanged
            txtNombreUsr.TextChanged -= txtNombreUsr_TextChanged;
            txtNombreUsr.Text = IngresoDatos.TextoNumerosMayusculas(txtNombreUsr.Text);
            txtNombreUsr.SelectionStart = cursorPosition;
            // Volvemos a habilitar el evento TextChanged
            txtNombreUsr.TextChanged += txtNombreUsr_TextChanged;
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
            {
                cmbGrupo.SelectedIndex = 0;
            }
        }

        private void FrmPreinscripciones_Load(object sender, EventArgs e)
        {

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

        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
