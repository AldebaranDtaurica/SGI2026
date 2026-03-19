using CapaDatos;
using CapaLogica;
using CapaServicios;
using System;
using System.Data;

namespace Capalogica
{
    internal class CL_Preinscripciones
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string Grupo { get; set; }
        public string Familia { get; set; }
        public string Username { get; set; }
        public int DiasCambioClave { get; set; }
        public string Passkey { get; set; }
        public string DigitPass { get; set; }

        CD_Usuario cdUsuario = new CD_Usuario();

        public CL_Preinscripciones() { }

        public void GuardarUsuario(CL_Usuario clusuario)
        {
            // Validación de email
            if (!CSR_ValidaMail.Valid(clusuario.Email))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }

            string PassAleatorio = CSR_Aleatorios.Armar().ToString();
            string PassPreHash = clusuario.Email.ToString() + PassAleatorio;
            string PassHash = CSR_Seguridad.Hash(PassPreHash).ToString();
            string DigitPassRecord = CSR_Seguridad.DigVerif(PassAleatorio).ToString();

            // Preparar el objeto para la capa de datos
            var datoUsuario = new CD_DatoUsuario
            {
                Apellido = clusuario.Apellido,
                Nombre = clusuario.Nombre,
                TipoDocumento = clusuario.TipoDocumento,
                Familia = clusuario.Familia,
                NumeroDocumento = clusuario.NumeroDocumento,
                Email = clusuario.Email,
                Grupo = clusuario.Grupo,
                Username = clusuario.Username,
                DiasCambioClave = clusuario.DiasCambioClave,
                Passkey = PassHash,
                DigitPass = DigitPassRecord
            };

            // Insertar usuario
            cdUsuario.InsertarUsuario(datoUsuario);

            CSR_ArmarMail.DireccionCorreo = clusuario.Email;
            CSR_ArmarMail.Asunto = "Nueva Contraseña";
            CSR_ArmarMail.NuevaContraseña = PassAleatorio;
            CSR_ArmarMail.Preparar();
        }

        public void ModificarUsuario(CL_Usuario clusuario)
        {
            try
            {
                if (string.IsNullOrEmpty(clusuario.Apellido) ||
                    string.IsNullOrEmpty(clusuario.Nombre) ||
                    string.IsNullOrEmpty(clusuario.TipoDocumento) ||
                    string.IsNullOrEmpty(clusuario.NumeroDocumento) ||
                    string.IsNullOrEmpty(clusuario.Email) ||
                    string.IsNullOrEmpty(clusuario.Username) ||
                    clusuario.DiasCambioClave <= 0)
                {
                    throw new ArgumentException("Uno o más campos no están correctamente llenados.");
                }

                if (!CSR_ValidaMail.Valid(clusuario.Email)) //
                {
                    throw new ArgumentException("El correo electrónico no es válido.");
                }

                var datoUsuario = new CD_DatoUsuario
                {
                    Apellido = clusuario.Apellido,
                    Nombre = clusuario.Nombre,
                    TipoDocumento = clusuario.TipoDocumento,
                    NumeroDocumento = clusuario.NumeroDocumento,
                    Email = clusuario.Email,
                    Grupo = clusuario.Grupo,
                    Familia = clusuario.Familia,
                    Username = clusuario.Username,
                    DiasCambioClave = clusuario.DiasCambioClave,
                };

                cdUsuario.ModificarUsuarioPass(datoUsuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al guardar el usuario: " + ex.Message);
            }
        }

        public void BajaUsuario(CL_Usuario clusuario)
        {
            try
            {
                if (string.IsNullOrEmpty(clusuario.Apellido) ||
                    string.IsNullOrEmpty(clusuario.Nombre) ||
                    string.IsNullOrEmpty(clusuario.TipoDocumento) ||
                    string.IsNullOrEmpty(clusuario.NumeroDocumento) ||
                    string.IsNullOrEmpty(clusuario.Email) ||
                    string.IsNullOrEmpty(clusuario.Username) ||
                    clusuario.DiasCambioClave <= 0)
                {
                    throw new ArgumentException("Uno o más campos no están correctamente llenados.");
                }

                if (!CSR_ValidaMail.Valid(clusuario.Email))
                {
                    throw new ArgumentException("El correo electrónico no es válido.");
                }

                var datoUsuario = new CD_DatoUsuario
                {
                    Apellido = clusuario.Apellido,
                    Nombre = clusuario.Nombre,
                    TipoDocumento = clusuario.TipoDocumento,
                    NumeroDocumento = clusuario.NumeroDocumento,
                    Email = clusuario.Email,
                    Grupo = clusuario.Grupo,
                    Familia = clusuario.Familia,
                    Username = clusuario.Username,
                    DiasCambioClave = clusuario.DiasCambioClave
                };

                cdUsuario.BajaUsuario(datoUsuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al guardar el usuario: " + ex.Message);
            }
        }

        public DataTable ConsultarUsuarios()
        {
            return cdUsuario.ConsultarUsuarios();
        }
    }
}
