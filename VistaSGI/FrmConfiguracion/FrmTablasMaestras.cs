using System;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmTablasMaestras : Form
    {
        public FrmTablasMaestras()
        {
            InitializeComponent();
        }

        private void FrmTablasMaestras_Load(object sender, EventArgs e)
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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
