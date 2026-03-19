using System;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmInscripcionFinales : Form
    {
        public FrmInscripcionFinales()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
