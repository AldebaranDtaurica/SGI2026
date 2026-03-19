using CapaDatos;
using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;


namespace CapaSistema.CSI_Model.Pass
{
    public class CSI_PassRespuesta
    {
        public int IdPregunta { get; set; }
        //public int IdUser { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        //public bool? Activo { get; set; }
        //public int? IdRespuesta { get; set; }



        public List<CSI_PassRespuesta> SeleccionarRespuesta(int IdUser)
        {
            CD_UsuarioRespuesta usuarioRespuesta = new CD_UsuarioRespuesta();
            DataTable respuesta = usuarioRespuesta.SelectPreguntas(IdUser);
            List<CSI_PassRespuesta> lista = new List<CSI_PassRespuesta>();
            foreach (DataRow fila in respuesta.Rows)
            {
                CSI_PassRespuesta passRespuesta = new CSI_PassRespuesta();
                passRespuesta.Pregunta = fila["Pregunta"].ToString();
                passRespuesta.Respuesta = fila["Respuesta"].ToString();
                lista.Add(passRespuesta);
            }
            return lista;
        }


        private readonly CD_Login login = new CD_Login();
        public bool Login(string username)
        {
            DataTable dt = login.Buscar(username);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            CargarCache(dt);
            return true;
        }

        private void CargarCache(DataTable datos)
        {
            if (datos.Rows.Count > 0)
            {
                // Cargar valores directamente desde el DataTable de forma más segura.
                CSE_UserCache.usuario = datos.Rows[0]["Username"]?.ToString() ?? string.Empty;
                CSE_UserCache.password = datos.Rows[0]["PassKey"]?.ToString() ?? string.Empty;
                CSE_UserCache.email = datos.Rows[0]["Email"]?.ToString() ?? string.Empty;
                CSE_UserCache.digito = datos.Rows[0]["DigVer"]?.ToString() ?? string.Empty;

                // Utilizamos TryParse para manejar correctamente las conversiones.
                if (int.TryParse(datos.Rows[0]["IdUser"]?.ToString(), out int idUser))
                {
                    CSE_UserCache.IdUser = idUser;
                }
                if (bool.TryParse(datos.Rows[0]["Bloqueo"]?.ToString(), out bool bloqueo))
                {
                    CSE_UserCache.bloqueo = bloqueo;
                }
                if (int.TryParse(datos.Rows[0]["CantError"]?.ToString(), out int intentos))
                {
                    CSE_UserCache.intentos = intentos;
                }
                if (DateTime.TryParse(datos.Rows[0]["BajaDay"]?.ToString(), out DateTime baja))
                {
                    CSE_UserCache.baja = baja;
                }
                if (bool.TryParse(datos.Rows[0]["Primer"]?.ToString(), out bool nuevo))
                {
                    CSE_UserCache.nuevo = nuevo;
                }
                if (bool.TryParse(datos.Rows[0]["Recupero"]?.ToString(), out bool recupero))
                {
                    CSE_UserCache.recupero = recupero;
                }
                if (int.TryParse(datos.Rows[0]["IdPersona"]?.ToString(), out int idPersona))
                {
                    CSE_UserCache.IdPersona = idPersona;
                }
                if (int.TryParse(datos.Rows[0]["CambiaCada"]?.ToString(), out int cambiaCada))
                {
                    CSE_UserCache.cambiaCada = cambiaCada;
                }
                if (DateTime.TryParse(datos.Rows[0]["AltaDay"]?.ToString(), out DateTime alta))
                {
                    CSE_UserCache.alta = alta;
                }
                if (DateTime.TryParse(datos.Rows[0]["ModDay"]?.ToString(), out DateTime modificacion))
                {
                    CSE_UserCache.modificacion = modificacion;
                }
                if (DateTime.TryParse(datos.Rows[0]["FechaActual"]?.ToString(), out DateTime fechaActual))
                {
                    CSE_UserCache.FechaActual = fechaActual;
                }
                CSE_UserCache.Familia = datos.Rows[0]["Fdescripcion"]?.ToString() ?? string.Empty;

            }
        }


        private readonly CD_Usuario usuario = new CD_Usuario();

        public void RecuperoUser(string Username, bool Recupero)
        {
            CD_Usuario cdUsuario = new CD_Usuario();
            var datoUsuario = new CD_DatoUsuario
            {
                Recupero = Recupero,
                Username = Username
            };

            // Insertar usuario
            cdUsuario.RecuperoUsuarioBit(datoUsuario);
        }

        public void RecuperoUser(string Username)
        {
            CD_Usuario cdUsuario = new CD_Usuario();

            string PassAleatorio = CSR_Aleatorios.Armar().ToString();
            string PassPreHash = CSE_UserCache.usuario.ToString() + PassAleatorio;
            string PassHash = CSR_Seguridad.Hash(PassPreHash).ToString();
            string PassHex = CSR_Seguridad.ConvertStringToHex(PassPreHash).ToString();
            string DigitPassRecord = CSR_Seguridad.DigVerif(PassHex).ToString();

            // Preparar el objeto para la capa de datos
            var datoUsuario = new CD_DatoUsuario
            {
                DiasCambioClave = CSE_UserCache.cambiaCada,
                Passkey = PassHash,
                DigitPass = DigitPassRecord,
                Username = CSE_UserCache.usuario
            };

            // Insertar usuario
            cdUsuario.RecuperoUsuario(datoUsuario);

            CSR_ArmarMail.DireccionCorreo = CSE_UserCache.email;
            CSR_ArmarMail.Asunto = "Recupero de Contraseña";
            CSR_ArmarMail.NuevaContraseña = PassAleatorio;
            CSR_ArmarMail.PrepararRec();
        }

        public List<CSI_PassRespuesta> SeleccionarPreguntasNew()
        {
            CD_UsuarioRespuesta usuarioRespuesta = new CD_UsuarioRespuesta();
            DataTable respuesta = usuarioRespuesta.SelectPreguntasNew();
            List<CSI_PassRespuesta> lista = new List<CSI_PassRespuesta>();
            foreach (DataRow fila in respuesta.Rows)
            {
                CSI_PassRespuesta passPreguntaNew = new CSI_PassRespuesta();
                passPreguntaNew.IdPregunta = Convert.ToInt32(fila["IdPregunta"].ToString());
                passPreguntaNew.Pregunta = fila["Pregunta"].ToString();
                lista.Add(passPreguntaNew);
            }
            return lista;
        }

        public void InsertarRespuesta(List<CSI_PassRespuesta> respuestas)
        {
            CD_UsuarioRespuesta usuarioRespuesta = new CD_UsuarioRespuesta();

            // Aquí pasamos las respuestas a la capa de datos. 
            // Necesitarás implementar la lógica de inserción dentro de CD_UsuarioRespuesta.
            foreach (var respuesta in respuestas)
            {
                usuarioRespuesta.InsertarRespuesta(CSE_UserCache.IdUser, respuesta.IdPregunta, respuesta.Respuesta);
            }
        }

        /*public void InsertarRespuesta(List<PreguntaRespuesta> respuestas)
        {
            CD_UsuarioRespuesta usuarioRespuesta = new CD_UsuarioRespuesta();
            usuarioRespuesta.InsertarRespuesta(CSE_UserCache.IdUser, R1, R2, R3);

        }*/
    }
}
