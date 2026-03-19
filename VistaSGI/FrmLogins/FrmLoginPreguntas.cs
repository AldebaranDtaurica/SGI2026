using CapaSesion;
using CapaSistema.CSI_Model.Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmLoginPreguntas : Form
    {
        bool Nuevo;
        bool Recupero;
        bool Linkbtn;

        public FrmLoginPreguntas(int idUser, bool nuevo, bool recupero, bool linkbtn = false)
        {
            InitializeComponent();
            Nuevo = nuevo;
            Recupero = recupero;
            Linkbtn = linkbtn;
            int IdUser = CSE_UserCache.IdUser;
            CSI_PassRespuesta cSI_PassRespuesta = new CSI_PassRespuesta();
            cSI_PassRespuesta.Login(CSE_UserCache.usuario);



            if (nuevo == true)
            {
                var PreguntasNew = cSI_PassRespuesta.SeleccionarPreguntasNew();
                lblPregunta1Id.Text = PreguntasNew[0].IdPregunta.ToString();
                lblPregunta2Id.Text = PreguntasNew[1].IdPregunta.ToString();
                lblPregunta3Id.Text = PreguntasNew[2].IdPregunta.ToString();
                lblPregunta1Id.Enabled = false;
                lblPregunta2Id.Enabled = false;
                lblPregunta3Id.Enabled = false;
                lblPregunta1.Text = PreguntasNew[0].Pregunta.ToString();
                lblPregunta2.Text = PreguntasNew[1].Pregunta.ToString();
                lblPregunta3.Text = PreguntasNew[2].Pregunta.ToString();
            }
            else if (recupero == true)
            {
                var Pregunta = cSI_PassRespuesta.SeleccionarRespuesta(IdUser);
                if (Pregunta.Count() > 0)
                {
                    lblPregunta1.Text = Pregunta[0].Pregunta.ToString();
                    lblPregunta2.Text = Pregunta[1].Pregunta.ToString();
                    lblPregunta3.Text = Pregunta[2].Pregunta.ToString();
                }
                else
                {
                    MessageBox.Show($"Su usuario no ha sido dado de alta correctamente, contacte al Administrador");
                }
            }
            else
            {
                MessageBox.Show($"Su usuario no ha sido dado de alta correctamente, contacte al Administrador");
                this.Close();
            }



            //this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPreguntas_Click(object sender, EventArgs e)
        {
            CSI_PassRespuesta cSI_PassRespuesta = new CSI_PassRespuesta();
            var Respuesta = cSI_PassRespuesta.SeleccionarRespuesta(CSE_UserCache.IdUser);

            if ((txtRespuesta1.Text == "" && txtRespuesta1.Text.Length <= 8) ||
                (txtRespuesta2.Text == "" && txtRespuesta2.Text.Length <= 8) ||
                (txtRespuesta3.Text == "" && txtRespuesta3.Text.Length <= 8))
            {
                MessageBox.Show($"Ingrese todas las respuestas, y las mismas deben superar los 8 caracteres");
            }
            else if (Nuevo == true)
            {
                //CSI_PassRespuesta CSI_PassRespuesta = new CSI_PassRespuesta();
                var respuestasNew = new List<CSI_PassRespuesta>
                {
                     new CSI_PassRespuesta { IdPregunta = Convert.ToInt32(lblPregunta1Id.Text), Respuesta = txtRespuesta1.Text.ToUpper() },
                     new CSI_PassRespuesta { IdPregunta = Convert.ToInt32(lblPregunta2Id.Text), Respuesta = txtRespuesta2.Text.ToUpper() },
                     new CSI_PassRespuesta { IdPregunta = Convert.ToInt32(lblPregunta3Id.Text), Respuesta = txtRespuesta3.Text.ToUpper() }
                 };
                // Llamamos al método InsertarRespuesta
                cSI_PassRespuesta.InsertarRespuesta(respuestasNew);
                MessageBox.Show($"Se guardaron sus respuestas, Bienvenido: {CSE_UserCache.usuario}");
                this.Close();
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.ShowDialog();


            }
            else if (Linkbtn == true && txtRespuesta1.Text.ToUpper() == Respuesta[0].Respuesta.ToString().ToUpper() && txtRespuesta2.Text.ToUpper() == Respuesta[1].Respuesta.ToString().ToUpper()
                && txtRespuesta3.Text.ToUpper() == Respuesta[2].Respuesta.ToString().ToUpper())
            {
                cSI_PassRespuesta.RecuperoUser(CSE_UserCache.usuario);
                MessageBox.Show($"Recuperación exitosa");
                this.Close();
                this.Dispose();
                Application.Restart();
            }
            else if (Recupero == true && Linkbtn == false && txtRespuesta1.Text.ToUpper() == Respuesta[0].Respuesta.ToString().ToUpper() && txtRespuesta2.Text.ToUpper() == Respuesta[1].Respuesta.ToString().ToUpper()
            && txtRespuesta3.Text.ToUpper() == Respuesta[2].Respuesta.ToString().ToUpper())
            {
                cSI_PassRespuesta.RecuperoUser(CSE_UserCache.usuario, Recupero == false);
                MessageBox.Show($"Validación exitosa, reingrese al sistema");
                this.Close();
                this.Dispose();
                Application.Restart();

            }
            else
                MessageBox.Show($"No se logró validar correctamente");
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
