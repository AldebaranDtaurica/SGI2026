using CapaLogica;
using System;
using System.Data;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmValidaPreinscripcion : Form
    {
        private readonly CL_CargaBox cl_BoxCarga = new CL_CargaBox();
        private readonly CL_ValidacionPreinscripciones cl_ValidacionPreinscripciones = new CL_ValidacionPreinscripciones();

        public FrmValidaPreinscripcion()
        {
            InitializeComponent();
            CL_CargaBox clBoxCarga = new CL_CargaBox();
            CargarComboBoxes(clBoxCarga);
        }

        private void CargarDatos()
        {


            DataTable dt = cl_ValidacionPreinscripciones.ObtenerValidacionPreinscripciones();
            dataGridView1.DataSource = dt;
        }


        private void CargarComboBoxes(CL_CargaBox clBoxCarga)
        {
            try
            {
                // Cargar y configurar ComboBox para Carreras
                DataTable dtIdCarreras = clBoxCarga.BoxCarreras();
                if (dtIdCarreras != null && dtIdCarreras.Rows.Count > 0)
                {
                    cmbCarrera.DataSource = dtIdCarreras;
                    cmbCarrera.DisplayMember = "NombreCarrera";
                    cmbCarrera.ValueMember = "IdCarrera";
                }

                // Cargar y configurar ComboBox para Alumnos
                DataTable dtIdPersona = clBoxCarga.BoxPersona();
                if (dtIdPersona != null && dtIdPersona.Rows.Count > 0)
                {
                    dtIdPersona.DefaultView.RowFilter = "Grupo = 'Postulante_Alumno'";
                    cmbAlumno.DataSource = dtIdPersona.DefaultView.ToTable(); // Usar la vista filtrada
                    cmbAlumno.DisplayMember = "Persona";
                    cmbAlumno.ValueMember = "IdPersona";
                }

                // Cargar y configurar ComboBox para Divisiones
                DataTable dtIdDivision = clBoxCarga.BoxDivision();
                if (dtIdDivision != null && dtIdDivision.Rows.Count > 0)
                {
                    dtIdDivision.DefaultView.RowFilter = "Anio = 1";
                    cmbDivision.DataSource = dtIdDivision.DefaultView.ToTable(); // Usar la vista filtrada
                    cmbDivision.DisplayMember = "Division";
                    cmbDivision.ValueMember = "IdCarreraDivision";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBoxes: " + ex.Message);
            }
        }

        private void CmbConsultar_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados
            int? idCarrera = cmbCarrera.SelectedValue as int?;
            int? idPersona = cmbAlumno.SelectedValue as int?;

            // Cargar datos filtrados
            CargarDatos(idCarrera, idPersona);
            //CargarDatos();
        }

        private void CargarDatos(int? idCarrera, int? idPersona)
        {
            DataTable dt = cl_ValidacionPreinscripciones.ObtenerValidacionPreinscripciones();

            // Inicializar el RowFilter vacío
            string filter = "";

            if (idCarrera.HasValue)
            {
                filter += $"IdCarrera = {idCarrera.Value}";
            }


            if (idPersona.HasValue)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"IdPersona = {idPersona.Value}";
            }

            // Aplicar el filtro al DataTable
            dt.DefaultView.RowFilter = filter;

            dataGridView1.DataSource = dt.DefaultView.ToTable(); // Asignar la vista filtrada al DataGridView
        }

        private void CmbGuardar_Click(object sender, EventArgs e)
        {

            // Obtener los valores seleccionados
            int? idCarrera = cmbCarrera.SelectedValue as int?;
            int? idPersona = cmbAlumno.SelectedValue as int?;
            int? idDivision = cmbDivision.SelectedValue as int?;
            txtSolicitud.Text = txtSolicitud.Text.ToString().Trim();
            txtLibroMatriz.Text = txtLibroMatriz.Text.ToString().Trim();
            txtFolio.Text = txtFolio.Text.ToString().Trim();
            txtLegajo.Text = txtLegajo.Text.ToString().Trim();
            txtObservaciones.Text = txtObservaciones.Text.ToString().Trim();
            chcCertMed.Checked = chcCertMed.Checked;
            chcDni.Checked = chcDni.Checked;
            chcFoto.Checked = chcFoto.Checked;
            chcTituloSec.Checked = chcTituloSec.Checked;
            chcValidar.Checked = chcValidar.Checked;
            chcProvicional.Checked = chcProvicional.Checked;
            chcListaEspera.Checked = chcListaEspera.Checked;
            cmbDivision.Text = cmbDivision.Text.ToString().Trim();


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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
