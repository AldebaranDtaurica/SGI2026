using CapaDatos;
using CapaServicios;
using CapaSesion;
using System;
using System.Data;

namespace CapaLogica
{
    public class CL_Login
    {
        private readonly CD_Login login = new CD_Login();
        private readonly CD_UsuarioPermiso permiso = new CD_UsuarioPermiso();


        public bool Login(string username, string password)
        {
            DataTable dt = login.Buscar(username);
            if (dt.Rows.Count == 0)
            {
                return false;
            }

            CargarCache(dt);
            return ValidarUsr(username, password);

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

        private bool ValidarUsr(string username, string password)
        {
            string userpass = username + password;
            string textoHex = CSR_Seguridad.ConvertStringToHex(userpass);
            int comprobarDig = CSR_Seguridad.DigVerif(textoHex);
            password = CSR_Seguridad.Hash(userpass);
            if (password != CSE_UserCache.password || comprobarDig != Convert.ToInt32(CSE_UserCache.digito))
            {
                return false;
            }
            string usuario = CSE_UserCache.usuario;
            _ = permiso.ConsultarPermisos(usuario);
            return true;
        }

        public bool ValidarUsrCondicion()
        {
            DateTime ModificacionControl = CSE_UserCache.modificacion.AddDays(CSE_UserCache.cambiaCada);
            if (CSE_UserCache.FechaActual > ModificacionControl || CSE_UserCache.recupero == true)
            {
                return false;
            }
            return true;
        }

        public bool ValidarUsrNuevo()
        {
            if (CSE_UserCache.nuevo == true)
            {
                return false;
            }
            return true;
        }

        public bool BloqueoUser()
        {
            if (CSE_UserCache.FechaActual > CSE_UserCache.baja || CSE_UserCache.bloqueo == true)
            {
                return false;
            }
            return true;
        }

    }
}
