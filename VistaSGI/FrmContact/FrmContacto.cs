using CapaServicios;
using CapaSesion;
using System;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmContacto : FrmBase
    {
        public FrmContacto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cmbMotivo.Text = cmbMotivo.SelectedItem?.ToString();
            string User = CSE_UserCache.usuario.ToString();
            txtInformacion.Text = txtInformacion.Text.ToString().Trim();


            if (cmbMotivo.Text == "" || txtInformacion.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }
            else
            {
                CSR_ArmarMail.Asunto = cmbMotivo.Text + " | Usuario " + User;
                CSR_ArmarMail.Mensaje = txtInformacion.Text;
                CSR_ArmarMail.DireccionCopCorreo = CSE_UserCache.email.ToString();
                // Aquí se puede agregar la lógica para enviar el mensaje de contacto
                CSR_ArmarMail.PrepararMsj();

                MessageBox.Show("Mensaje enviado correctamente. Nos pondremos en contacto contigo pronto.");
                this.Hide();
            }
        }

        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmContacto_Load(object sender, EventArgs e)
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
    }
}
