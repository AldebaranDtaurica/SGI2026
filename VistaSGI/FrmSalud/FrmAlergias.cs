using CapaLogica.CL_Model.Pers;
using System;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmAlergias : FrmBase
    {
        public FrmAlergias()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //bool chcActivo = true;
            CL_PersSaludAlergias PersSaludAlergias = new CL_PersSaludAlergias
            {
                Medicamentos = chcAmedic.Checked,
                InternacMedicamentos = chcIntmedic.Checked,
                PicInsect = chcApicinsecto.Checked,
                InternacPicInsect = chcPicinsecto.Checked,
                Vacunas = chcAvac.Checked,
                InternacVacunas = chcIntVac.Checked,
                Estacionales = chcEst.Checked,
                InternacEstacionales = chcIntEst.Checked,
                Alimentos = chcAlim.Checked,
                InternacAlimentos = chcIntAlim.Checked,
                Otras = chcOtras.Checked,
                InternacOtras = chcIntOtras.Checked,
                DescripOtras = txtDescAdic.Text,
            };

            PersSaludAlergias.GuardarDatos(PersSaludAlergias);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
