using System;
using System.Windows.Forms;
using VistaSGI.FrmDatosPersonales;

namespace VistaSGI
{
    public partial class FrmMenuDatos : Form
    {
        public FrmMenuDatos()
        {
            InitializeComponent();
        }

        //instanciar formulario de datos de alumnos
        private void DATOSALUMNO_Click_1(object sender, EventArgs e)
        {
            FrmAlumnosPreInscripcionA frmAlumnoPreinsc = new FrmAlumnosPreInscripcionA();
            _ = frmAlumnoPreinsc.ShowDialog(this);
        }
        private void DOMICILIO_Click(object sender, EventArgs e)
        {
            FrmDomicilio frmDomicilio = new FrmDomicilio();
            _ = frmDomicilio.ShowDialog();
        }

        private void REFERENTE_Click_1(object sender, EventArgs e)
        {
            FrmReferente frmReferente = new FrmReferente();
            _ = frmReferente.ShowDialog(this);
        }

        private void CURSADA_Click_1(object sender, EventArgs e)
        {
            FrmInscripcionCursada frmInscripcionCursada = new FrmInscripcionCursada();
            _ = frmInscripcionCursada.ShowDialog(this);
        }

        private void FINALES_Click_1(object sender, EventArgs e)
        {
            FrmInscripcionFinales frmInscripcionFinales = new FrmInscripcionFinales();
            _ = frmInscripcionFinales.ShowDialog(this);
        }

        private void OBRASOCIAL_Click_1(object sender, EventArgs e)
        {
            FrmObraSocial frmObraSocial = new FrmObraSocial();
            _ = frmObraSocial.ShowDialog(this);
        }

        private void ESFUERZO_Click_1(object sender, EventArgs e)
        {
            FrmActFisica frmActFisica = new FrmActFisica();
            _ = frmActFisica.ShowDialog(this);
        }

        private void ALERGIAS_Click_1(object sender, EventArgs e)
        {
            FrmAlergias frmAlergias = new FrmAlergias();
            _ = frmAlergias.ShowDialog(this);
        }

        private void CONDICIONESEXTRA_Click_1(object sender, EventArgs e)
        {
            FrmCondicionSalud frmCondicionSalud = new FrmCondicionSalud();
            _ = frmCondicionSalud.ShowDialog(this);
        }

        private void DISCAPACIDAD_Click_1(object sender, EventArgs e)
        {
            FrmDiscapacidad frmDiscapacidad = new FrmDiscapacidad();
            _ = frmDiscapacidad.ShowDialog(this);
        }

        private void INTERNACIONES_Click_1(object sender, EventArgs e)
        {
            FrmInternaciones frmInternaciones = new FrmInternaciones();
            _ = frmInternaciones.ShowDialog(this);
        }

        private void OPERACIONES_Click_1(object sender, EventArgs e)
        {
            FrmOperaciones frmOperaciones = new FrmOperaciones();
            _ = frmOperaciones.ShowDialog(this);
        }

        private void MEDICACIONHABITUAL_Click_1(object sender, EventArgs e)
        {
            FrmMedicacion frmMedicacion = new FrmMedicacion();
            _ = frmMedicacion.ShowDialog(this);
        }

        private void OTROSDATOS_Click_1(object sender, EventArgs e)
        {
            FrmDatosAdicionales frmDatosAdicionales = new FrmDatosAdicionales();
            _ = frmDatosAdicionales.ShowDialog(this);
        }

        private void TRANSPORTE_Click_1(object sender, EventArgs e)
        {
            FrmTransporte frmTransporte = new FrmTransporte();
            _ = frmTransporte.ShowDialog(this);
        }

        private void INSCRIPTOCARRERA_Click_1(object sender, EventArgs e)
        {
            FrmAlumnado frmAlumnado = new FrmAlumnado();
            _ = frmAlumnado.ShowDialog();
        }

        private void PORCURSADA_Click_1(object sender, EventArgs e)
        {
            FrmInscripcionCursada frmInscripcionCursada = new FrmInscripcionCursada();
            _ = frmInscripcionCursada.ShowDialog(this);
        }

        private void PORFINALES_Click_1(object sender, EventArgs e)
        {
            FrmInscripcionFinales frmInscripcionFinales = new FrmInscripcionFinales();
            _ = frmInscripcionFinales.ShowDialog(this);
        }

        private void ADJUNTOS_Click_1(object sender, EventArgs e)
        {
            FrmAdjuntosEstudiantes frmAdjuntosEstudiantes = new FrmAdjuntosEstudiantes();
            _ = frmAdjuntosEstudiantes.ShowDialog(this);
        }

        private void LEGAJOS_Click(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
