using CapaLogica;
using CapaServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSesion;
using CapaSistema.CSI_Model.Pass;


namespace VistaSGI
{
     public partial class FrmLogin : Form
     {

            CL_Login login = new CL_Login();
            CL_IngresoDatos IngresoDatos = new CL_IngresoDatos();

            public FrmLogin()
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterScreen;
                btnVerPass.MouseDown += btnVerPass_MouseDown;
                btnVerPass.MouseUp += btnVerPass_MouseUp;
                txtPasword.TextChanged += txtPasword_TextChanged;
                int idUser = CSE_UserCache.IdUser;

             }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                if (login.Login(textUsername.Text, txtPasword.Text))
                {
                    if (login.ValidarUsrCondicion() == false || login.ValidarUsrNuevo() == false)
                    {
                    MessageBox.Show("Debe cambiar la contraseña para continuar,\n y responder las preguntas de seguridad");
                    this.Hide();
                    // Abre el formulario principal
                    FrmLoginActualizacion FrmLoginActualizacion = new FrmLoginActualizacion(CSE_UserCache.IdUser);
                    FrmLoginActualizacion.Show();
                    }
                    else if (login.BloqueoUser())
                    {
                        MessageBox.Show("Usuario bloqueado, si el inconveniente persiste \n contacte al administrador del sistema");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Logueado correctamente, bienvenido {CSE_UserCache.usuario}");
                        this.Hide();
                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.Show();
                    }
                 }  else 
                    MessageBox.Show("Login incorrecto");
                    this.Hide();
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            CSI_PassRespuesta cSI_PassRespuesta = new CSI_PassRespuesta();
                if (cSI_PassRespuesta.Login(textUsername.Text))
                {
                int idUser = CSE_UserCache.IdUser;
                bool linkbtn = true;
                MessageBox.Show($"Complete las preguntas para recuperar su contraseña {CSE_UserCache.usuario}");
                CSE_UserCache.recupero = true;
                FrmLoginPreguntas loginPreguntas = new FrmLoginPreguntas(CSE_UserCache.IdUser, CSE_UserCache.nuevo, CSE_UserCache.recupero, linkbtn);
                loginPreguntas.Show();
                }
                else
                {
                txtPasword.Enabled = false;
                btnLoin.IsAccessible = false;
                textUsername.Focus();
                MessageBox.Show("Si no recuerda su contraseña, complete su usuario para avanzar y recuperarla \n" +
                " o contacte al administrador del sistema");
                }
            }

            private void VerificarPasswordYHabilitarBoton()
            {
               btnVerPass.Enabled = !string.IsNullOrEmpty(txtPasword.Text);
            }

            private void txtPasword_TextChanged(object sender, EventArgs e)
            {
                txtPasword.PasswordChar = '*';  // Ocultamos el texto con un carácter de contraseña
                VerificarPasswordYHabilitarBoton();
            }

            private void btnVerPass_MouseDown(object sender, MouseEventArgs e)
            {
                txtPasword.PasswordChar = '\0';  // Mostramos los caracteres
            }

            private void btnVerPass_MouseUp(object sender, MouseEventArgs e)
            {
                txtPasword.PasswordChar = '*';  // Volvemos a ocultar los caracteres
            }

            private void textUsername_TextChanged(object sender, EventArgs e)
            {
                int cursorPosition = textUsername.SelectionStart;
                textUsername.Text = IngresoDatos.TextoMayusculas(textUsername.Text);
                textUsername.SelectionStart = cursorPosition;
            }
      }
}
