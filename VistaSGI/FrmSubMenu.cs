using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmSubMenu : Form
    {
        public FrmSubMenu()
        {
            InitializeComponent();
        }

        private void TlsSubMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void USUARIOS_Click(object sender, EventArgs e)
        {
            FrmDomicilio frmDomicilio = new FrmDomicilio();
            _ = frmDomicilio.ShowDialog(this);
        }

        private void DATOSALUMNO_Click(object sender, EventArgs e)
        {
            FrmAlumnosPreInscripcionA frmAlumnoPreinsc = new FrmAlumnosPreInscripcionA();
            _ = frmAlumnoPreinsc.ShowDialog(this);
        }

        private void REFERENTE_Click(object sender, EventArgs e)
        {
            FrmReferente frmReferente = new FrmReferente();
            _ = frmReferente.ShowDialog(this);
        }

        private void CURSADA_Click(object sender, EventArgs e)
        {
            FrmInscripcionCursada frmInscripcionCursada = new FrmInscripcionCursada();
            _ = frmInscripcionCursada.ShowDialog(this);
        }

        private void FINALES_Click(object sender, EventArgs e)
        {
            FrmInscripcionFinales frmInscripcionFinales = new FrmInscripcionFinales();
            _ = frmInscripcionFinales.ShowDialog(this);
        }

        private void OBRASOCIAL_Click(object sender, EventArgs e)
        {
            FrmObraSocial frmObraSocial = new FrmObraSocial();
            _ = frmObraSocial.ShowDialog(this);
        }

        private void ESFUERZO_Click(object sender, EventArgs e)
        {
            FrmActFisica frmActFisica = new FrmActFisica();
            _ = frmActFisica.ShowDialog(this);
        }

        private void ALERGIAS_Click(object sender, EventArgs e)
        {
            FrmAlergias frmAlergias = new FrmAlergias();
            _ = frmAlergias.ShowDialog(this);
        }

        private void CONDICIONESEXTRA_Click(object sender, EventArgs e)
        {
            FrmCondicionSalud frmCondicionSalud = new FrmCondicionSalud();
            _ = frmCondicionSalud.ShowDialog(this);
        }

        private void DISCAPACIDAD_Click(object sender, EventArgs e)
        {
            FrmDiscapacidad frmDiscapacidad = new FrmDiscapacidad();
            _ = frmDiscapacidad.ShowDialog(this);
        }

        private void INTERNACIONES_Click(object sender, EventArgs e)
        {
            FrmInternaciones frmInternaciones = new FrmInternaciones();
            _ = frmInternaciones.ShowDialog(this);
        }

        private void OPERACIONES_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOperaciones = new FrmOperaciones();
            _ = frmOperaciones.ShowDialog(this);
        }

        private void MEDICACIONHABITUAL_Click(object sender, EventArgs e)
        {
            FrmMedicacion frmMedicacion = new FrmMedicacion();
            _ = frmMedicacion.ShowDialog(this);
        }

        private void OTROSDATOS_Click(object sender, EventArgs e)
        {
            FrmDatosAdicionales frmDatosAdicionales = new FrmDatosAdicionales();
            _ = frmDatosAdicionales.ShowDialog(this);
        }

        private void TRANSPORTE_Click(object sender, EventArgs e)
        {
            FrmTransporte frmTransporte = new FrmTransporte();
            _ = frmTransporte.ShowDialog(this);
        }

        private void ADJUNTOS_Click(object sender, EventArgs e)
        {
            FrmAdjuntosEstudiantes frmAdjuntosEstudiantes = new FrmAdjuntosEstudiantes();
            _ = frmAdjuntosEstudiantes.ShowDialog(this);
        }

        private void PORFINALES_Click(object sender, EventArgs e)
        {
            FrmInscripcionFinales frmInscripcionFinales = new FrmInscripcionFinales();
            _ = frmInscripcionFinales.ShowDialog(this);
        }

        private void PORCURSADA_Click(object sender, EventArgs e)
        {
            FrmInscripcionCursada frmInscripcionCursada = new FrmInscripcionCursada();
            _ = frmInscripcionCursada.ShowDialog(this);
        }

        private void INSCRIPTOCARRERA_Click(object sender, EventArgs e)
        {
            FrmAlumnos frmAlumnos = new FrmAlumnos();
            _= frmAlumnos.ShowDialog(this);
        }
    }
}
