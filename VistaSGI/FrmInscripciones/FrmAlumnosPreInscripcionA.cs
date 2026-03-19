using CapaLogica;
using CapaSesion;
using System;
using System.Data;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmAlumnosPreInscripcionA : Form
    {

        //CL_CargaBox clBoxCarga;

        public FrmAlumnosPreInscripcionA()
        {
            InitializeComponent();
            CL_CargaBox clBoxCarga = new CL_CargaBox(); // Ensure this is properly instantiated
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboBoxes(clBoxCarga); // Pass the instantiated object
            //lblidPersona.Text = CSE_UserCache.id.ToString();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {

            // Validar que todos los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            try
            {
                lblidPersona.Text = Convert.ToString(CSE_UserCache.id);
                //int idPersona;
                if (!int.TryParse(lblidPersona.Text, out int idPersona))
                {
                    MessageBox.Show("El ID de persona no es un número válido.");
                    return;
                }

                // Crear una instancia y asignar
                CL_AlmunoPreInscripcion datoAlumnoPre = new CL_AlmunoPreInscripcion(
                    txtApellido.Text,
                    txtNombre.Text,
                    int.Parse(cmbGenero.SelectedValue.ToString()),
                    int.Parse(cbmTipoDoc.SelectedValue.ToString()),
                    int.Parse(cmbIdSinDniARG.SelectedValue?.ToString() ?? string.Empty),
                    txtDocDescripOtros.Text,
                    int.Parse(txtNumDoc.Text),
                    txtLetraDoc.Text,
                    txtCUIL.Text,
                    dttFechaNac.Value,
                    txtLugNacionalidad.Text,
                    int.Parse(cmbIdNacionalidad.SelectedValue.ToString()),
                    int.Parse(cbmIdProvincia.SelectedValue.ToString()),
                    int.Parse(cmbIdPartido.SelectedValue.ToString()),
                    int.Parse(cmbIdLocalidad.SelectedValue.ToString()),
                    int.Parse(cmbEstadoCivil.SelectedValue.ToString()),
                    int.Parse(nmrCantHijos.Text),
                    int.Parse(nmrFamiliaresCargo.Text),
                    cmbGrupo.SelectedValue?.ToString() ?? string.Empty,
                    int.Parse(cmbIdInstitucion.SelectedValue?.ToString() ?? string.Empty),
                    int.Parse(cmbIdCarrera.SelectedValue?.ToString() ?? string.Empty),
                    txtDescTituloSec.Text,
                    txtEscuela.Text,
                    chcCompleto.Checked,
                    txtNoSecComp_NActa_AAdm.Text,
                    cmbDistrito.SelectedValue?.ToString() ?? string.Empty,
                    int.Parse(nmrYearEgreso.Text),
                    txtInsititucionEst.Text,
                    cmbTipoTitulo.SelectedValue?.ToString() ?? string.Empty,
                    cbmGrado.SelectedValue?.ToString() ?? string.Empty,
                    txtTitulo.Text,
                    int.Parse(nmrEgresoYear.Text),
                    chcTrabaja.Checked,
                    cbmActividad.SelectedValue?.ToString() ?? string.Empty,
                    txtHorario.Text,
                    cmbObraSocial.SelectedValue?.ToString() ?? string.Empty,
                    chcObraSocial.Checked,
                    txtNumAfiliadoOS.Text,
                    txtCodArea.Text,
                    txtTelefono.Text,
                    txtMail.Text
                );

                datoAlumnoPre.GuardarPreinscripcion();
                MessageBox.Show("Usuario guardado correctamente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string mensajeError = $"Ocurrió un error inesperado: {ex.Message}\n" +
                                      $"Tipo de error: {ex.GetType().Name}\n" +
                                      $"Detalles: {ex.StackTrace}" +
                                      $"Error dato: {ex.Data}";

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxes(CL_CargaBox clBoxCarga)
        {
            try
            {
                // Cargar tipo de documento
                DataTable dtTipoDoc = clBoxCarga.BoxTipoDoc();
                cbmTipoDoc.DataSource = dtTipoDoc;
                cbmTipoDoc.DisplayMember = "DescTDoc";
                cbmTipoDoc.ValueMember = "IdTDoc";
                DataTable dtGenero = clBoxCarga.BoxGenero();
                cmbGenero.DataSource = dtGenero;
                cmbGenero.DisplayMember = "Genero";
                cmbGenero.ValueMember = "IdGenero";
                DataTable dtNacionalidad = clBoxCarga.BoxNacionalidad();
                cmbIdNacionalidad.DataSource = dtNacionalidad;
                cmbIdNacionalidad.DisplayMember = "Nacionalidad";
                cmbIdNacionalidad.ValueMember = "IdNacionalidad";
                DataTable dtEstadoCivil = clBoxCarga.BoxEstCivil();
                cmbEstadoCivil.DataSource = dtEstadoCivil;
                cmbEstadoCivil.DisplayMember = "DescripcionEC";
                cmbEstadoCivil.ValueMember = "IdEstCivil";
                DataTable dtPartido = clBoxCarga.BoxPartido();
                cmbIdPartido.DataSource = dtPartido;
                cmbIdPartido.DisplayMember = "Partido";
                cmbIdPartido.ValueMember = "IdPartido";
                DataTable dtDistrito = clBoxCarga.BoxPartido();
                cmbDistrito.DataSource = dtDistrito;
                cmbDistrito.DisplayMember = "Partido";
                cmbDistrito.ValueMember = "Partido";
                DataTable dtIdSinDniARG = clBoxCarga.BoxSinDniArg();
                cmbIdSinDniARG.DataSource = dtIdSinDniARG;
                cmbIdSinDniARG.DisplayMember = "SinDniDescrip";
                cmbIdSinDniARG.ValueMember = "IdSinDniArg";
                DataTable dtIdProvincia = clBoxCarga.BoxProvincia();
                cbmIdProvincia.DataSource = dtIdProvincia;
                cbmIdProvincia.DisplayMember = "Provincia";
                cbmIdProvincia.ValueMember = "IdProvincia";
                DataTable dtIdLocalidad = clBoxCarga.BoxLocalidad();
                cmbIdLocalidad.DataSource = dtIdLocalidad;
                cmbIdLocalidad.DisplayMember = "Localidad";
                cmbIdLocalidad.ValueMember = "IdLocalidad";
                DataTable dtIdPersGrupo = clBoxCarga.BoxPersGrupo(); //Fijar
                dtIdPersGrupo.DefaultView.RowFilter = "IdTipoPersona = 7";
                cmbGrupo.DataSource = dtIdPersGrupo;
                cmbGrupo.DisplayMember = "TipoPersona";
                cmbGrupo.ValueMember = "TipoPersona";
                DataTable dtIdInstitucion = clBoxCarga.BoxInstitucion();
                cmbIdInstitucion.DataSource = dtIdInstitucion;
                cmbIdInstitucion.DisplayMember = "NombreInstitucion";
                cmbIdInstitucion.ValueMember = "IdInstitucion";
                DataTable dtIdCarreras = clBoxCarga.BoxCarreras();
                cmbIdCarrera.DataSource = dtIdCarreras;
                cmbIdCarrera.DisplayMember = "NombreCarrera";
                cmbIdCarrera.ValueMember = "IdCarrera";
                DataTable dtIngresoTitulo = clBoxCarga.BoxIngresoTitulo();
                cmbTipoTitulo.DataSource = dtIngresoTitulo;
                cmbTipoTitulo.DisplayMember = "Descripcion";
                cmbTipoTitulo.ValueMember = "Descripcion";
                DataTable dtActividades = clBoxCarga.BoxActividades();
                cbmActividad.DataSource = dtActividades;
                cbmActividad.DisplayMember = "ActividadesDesc";
                cbmActividad.ValueMember = "ActividadesDesc";
                DataTable dtObraSocial = clBoxCarga.BoxObraSocial();
                cmbObraSocial.DataSource = dtObraSocial;
                cmbObraSocial.DisplayMember = "DenominacionOs";
                cmbObraSocial.ValueMember = "DenominacionOs";
                DataTable dtGradoTipo = clBoxCarga.BoxTituloGrado();
                cbmGrado.DataSource = dtGradoTipo;
                cbmGrado.DisplayMember = "Tipo";
                cbmGrado.ValueMember = "Tipo";

                if (cbmTipoDoc.Items.Count > 0) cbmTipoDoc.SelectedIndex = 0;
                if (cmbGenero.Items.Count > 0) cmbGenero.SelectedIndex = 0;
                if (cmbIdNacionalidad.Items.Count > 0) cmbIdNacionalidad.SelectedIndex = 0;
                if (cmbEstadoCivil.Items.Count > 0) cmbEstadoCivil.SelectedIndex = 0;
                if (cmbIdPartido.Items.Count > 0) cmbIdPartido.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBoxes: " + ex.Message);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
