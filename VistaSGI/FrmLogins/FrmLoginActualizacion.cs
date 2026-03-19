using CapaLogica;
using CapaServicios;
using CapaSesion;
using CapaSistema;
using System;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmLoginActualizacion : Form
    {
        public FrmLoginActualizacion(int IdUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnVerPass.MouseDown += btnVerPass_MouseDown;
            btnVerPass.MouseUp += btnVerPass_MouseUp;
            btnVerPass2.MouseDown += btnVerPass2_MouseDown;
            btnVerPass2.MouseUp += btnVerPass2_MouseUp;
            txtPassword1.TextChanged += TxtPassword1_TextChanged;
            txtPassword2.TextChanged += TxtPassword2_TextChanged;
            lblErrores.Visible = false;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text.ToString() == "" || txtPassword2.Text.ToString() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }
            else if (txtPassword1.Text.ToString() != txtPassword2.Text.ToString())
            {
                MessageBox.Show("Compruebe los datos ingresados.");
            }
            else if (txtPassword1.Text.ToString() == txtPassword2.Text.ToString())
            {
                string password = txtPassword1.Text.ToString();
                if (CL_ValidaPoliticasPass.ValCar(password, CSI_ConfiguracionCache.caracteres, CSI_ConfiguracionCache.mayusculas,
                    CSI_ConfiguracionCache.numeros, CSI_ConfiguracionCache.especiales, CSI_ConfiguracionCache.passAnteriores,
                    CSI_ConfiguracionCache.noDatosPersonales))
                {

                    string PassPreHash = CSE_UserCache.usuario.ToString() + password;
                    string PassHash = CSR_Seguridad.Hash(PassPreHash).ToString();
                    string PassPreHex = CSR_Seguridad.ConvertStringToHex(PassPreHash);
                    string DigitPassRecord = CSR_Seguridad.DigVerif(PassPreHex).ToString();

                    bool nuevoAnt = CSE_UserCache.nuevo;
                    bool recuperoAnt = CSE_UserCache.recupero;

                    CL_Usuario usuario = new CL_Usuario
                    {
                        Username = CSE_UserCache.usuario, // Asignar el nombre de usuario
                        Passkey = PassHash,
                        DigitPass = DigitPassRecord,
                        Recupero = recuperoAnt,
                        Nuevo = nuevoAnt
                    };


                    //usuario.ModificarUsuarioPass(usuario);

                    try
                    {
                        usuario.ModificarUsuarioPass(usuario);
                        MessageBox.Show("Contraseña actualizada correctamente.", "Éxito",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    catch (ArgumentException aex)
                    {
                        // mensaje de validación o negocio
                        MessageBox.Show(aex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception ex)
                    {
                        // loguear ex (logger, EventLog, archivo...)
                        MessageBox.Show("Ocurrió un error inesperado. Contacte al administrador." + "(" + @ex.Message + ")", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    txtPassword1.Text = "";
                    txtPassword2.Text = "";
                    txtPassword1.Focus();

                    //FrmLoginPreguntas frmLoginPreguntas = new FrmLoginPreguntas(CSE_UserCache.IdUser, nuevoAnt, recuperoAnt);
                    //frmLoginPreguntas.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Compruebe las políticas de seguridad.");
                }
            }
        }


        private void VerificarPasswordYHabilitarBoton()
        {
            btnVerPass.Enabled = !string.IsNullOrEmpty(txtPassword1.Text);
            btnVerPass.Enabled = !string.IsNullOrEmpty(txtPassword2.Text);
        }

        private void btnVerPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword1.PasswordChar = '\0';  // Mostramos los caracteres
        }

        private void btnVerPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword1.PasswordChar = '*';  // Volvemos a ocultar los caracteres
        }
        private void btnVerPass2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword2.PasswordChar = '\0';  // Mostramos los caracteres
        }

        private void btnVerPass2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword2.PasswordChar = '*';  // Volvemos a ocultar los caracteres
        }

        private void TxtPassword1_TextChanged(object sender, EventArgs e)
        {
            txtPassword1.PasswordChar = '*';// Ocultamos el texto con un carácter de contraseña
            VerificarPasswordYHabilitarBoton();
        }
        private void TxtPassword2_TextChanged(object sender, EventArgs e)
        {
            txtPassword2.PasswordChar = '*';// Ocultamos el texto con un carácter de contraseña
            VerificarPasswordYHabilitarBoton();
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
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPass2_Click(object sender, EventArgs e)
        {

        }
    }
}