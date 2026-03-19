using CapaLogica.CL_Model.Pers;
using System;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmActFisica : Form
    {
        public FrmActFisica()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            //bool chcActivo = true;
            CL_PersSaludEjercicio PersSaludEjercicio = new CL_PersSaludEjercicio
            {
                //IdPersSaludEjercicio = int.Parse(txtId.Text),
                //IdPersona = int.Parse(txtIdPersona.Text),

                //Activo = chcActivo,
                Desmayo = chcDesmayos.Checked,
                MayorCansancioQ = chcCansancioReg.Checked,
                DolorPecho = chcDolorPecho.Checked,
                Palpitaciones = chcPalpitaciones.Checked,
                Mareos = chcMareos.Checked,
                DifRespirarActFisic = chcDifRespiratoria.Checked,
                //Fecha = DateTime.Parse(txtFecha.Text),
                //Usuario = txtUsuario.Text
            };

            PersSaludEjercicio.GuardarDatos(PersSaludEjercicio);
        }

        // Llama al método para guardar los datos en la capa de datos

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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }


}