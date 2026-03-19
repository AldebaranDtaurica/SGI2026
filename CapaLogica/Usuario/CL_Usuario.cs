using CapaDatos;
using CapaServicios;
using System;
using System.Data;
using System.Linq;

namespace CapaLogica
{
    public class CL_Usuario
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string Grupo { get; set; }
        public string Familia { get; set; }
        public string Username { get; set; }
        public bool Recupero { get; set; }
        public bool Nuevo { get; set; }
        public int DiasCambioClave { get; set; }
        public string Passkey { get; set; }
        public string DigitPass { get; set; }
        public int IdPersona { get; set; } //Comprobar
        public int RowIndex { get; set; }
        public int IdUser { get; set; }

        CD_Usuario cdUsuario = new CD_Usuario();
        CD_UsuarioPermiso cdUsuarioPermiso = new CD_UsuarioPermiso();

        public CL_Usuario() { }

        public void GuardarUsuario(CL_Usuario clusuario)
        {
            // Validación de email
            if (!CSR_ValidaMail.Valid(clusuario.Email))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }

            string PassAleatorio = CSR_Aleatorios.Armar().ToString();
            string PassPreHash = clusuario.Username.ToString() + PassAleatorio;
            string PassHash = CSR_Seguridad.Hash(PassPreHash).ToString();
            string PassPreHex = CSR_Seguridad.ConvertStringToHex(PassPreHash);
            string DigitPassRecord = CSR_Seguridad.DigVerif(PassPreHex).ToString();

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
                DigitPass = DigitPassRecord,
                Recupero = clusuario.Recupero,
                Nuevo = clusuario.Nuevo
            };

            // Insertar usuario
            cdUsuario.InsertarUsuario(datoUsuario);

            CSR_ArmarMail.DireccionCorreo = clusuario.Email;
            CSR_ArmarMail.Asunto = "Nueva Contraseña";
            CSR_ArmarMail.NuevaContraseña = PassAleatorio;
            CSR_ArmarMail.Preparar();
        }

        public void ModificarUsuarioPass(CL_Usuario clusuario)
        {
            try
            {
                if (string.IsNullOrEmpty(clusuario.DigitPass) ||
                    string.IsNullOrEmpty(clusuario.Passkey) ||
                    string.IsNullOrEmpty(clusuario.Username))
                {
                    throw new ArgumentException("Uno o más campos no están correctamente llenados.");
                }

                var datoUsuario = new CD_DatoUsuario
                {
                    DigitPass = clusuario.DigitPass,
                    Passkey = clusuario.Passkey,
                    Username = clusuario.Username,
                    Nuevo = clusuario.Nuevo,
                    Recupero = clusuario.Recupero
                };

                cdUsuario.ModificarUsuarioPass(datoUsuario);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocurrió un error al guardar el usuario: " + ex.Message);
                //Console.WriteLine("Ocurrió un error al guardar el usuario: " + ex.Message);
            }
        }

        /*public void BajaUsuario(CL_Usuario clusuario)
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
        }*/

        public DataTable ConsultarUsuarios()
        {
            return cdUsuario.ConsultarUsuarios(); //verificar si se necesita el parametro usuario
        }

        public DataTable ConsultarUsuarios(string familia)
        {
            // 1. Obtenemos todos los usuarios
            DataTable dtUsuarioPP = ConsultarUsuarios();
            if (!string.IsNullOrEmpty(familia))
            {
                DataView dv = new DataView(dtUsuarioPP);
                dv.RowFilter = string.Format("Fdescripcion = '{0}'", familia.Replace("'", "''"));
                return dv.ToTable();
            }

            return dtUsuarioPP;
        }

        public int ConsultarUsuarioId(int IdPersona)
        {
            DataTable dtUsuarioId = ConsultarUsuarios();
            var filasFiltradas = dtUsuarioId.AsEnumerable().Where(row => row.Field<int>("IdPersona") == IdPersona);
            int UsuarioId = dtUsuarioId.Columns.Contains("IdUsusario") && filasFiltradas.Any()
                ? filasFiltradas.First().Field<int>("IdUsusario") : -1; // Retorna -1 si no se encuentra el usuario
            if (filasFiltradas.Any())
            {
                return UsuarioId;
            }
            else
            {
                return UsuarioId = 0;
            }
        }



        public bool ExisteUsuario(string usuario, string documento)
        {
            string buscado = usuario.Trim().ToUpper();
            string buscado2 = documento.Trim();
            DataTable dt = ConsultarUsuarios();
            foreach (DataRow fila in dt.Rows)
            {
                string existente = fila["Usuario"].ToString().Trim().ToUpper();
                string existente2 = fila["TipoNumDoc"].ToString().Trim();
                if (existente == buscado || existente2 == buscado2)
                {
                    return true;    // El usuario ya existe o el tipo y num de doc fueron registrados
                }
            }
            return false;
        }


        public bool ComprobarFamiliaUsuario(string usuarioFamilia)
        {
            if (usuarioFamilia == "PRECEPTORES" || usuarioFamilia == "PROFESORES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        public DataTable AsignacionProfesorPreceptor(string usuario, string familia, bool activo)
        {
            DataTable dt = cdUsuarioPermiso.AsignacionProfesorPreceptor(usuario, familia);
            var filasFiltradas = dt.AsEnumerable().Where(row => row.Field<bool>("Asignado") == activo);
            if (filasFiltradas.Any())
            {
                return filasFiltradas.CopyToDataTable();
            }
            else
            {
                return dt.Clone();
            }
        }*/

        public DataTable AsignacionProfesorPreceptor(string usuario, string familia, bool activo)
        {
            DataTable dt = cdUsuarioPermiso.AsignacionProfesorPreceptor(usuario, familia);
            if (dt == null || dt.Rows.Count == 0) return dt ?? new DataTable();
            if (!dt.Columns.Contains("Asignado")) return dt.Clone();

            var filas = dt.AsEnumerable()
                .Where(row => row.Field<bool?>("Asignado") == activo).ToList();

            return filas.Any() ? filas.CopyToDataTable() : dt.Clone();
        }

        /*public DataTable ConsultarUsuarios(string Username)
        {
            DataTable dt = cdUsuario.ConsultarUsuarios();
            var filasFiltradas = dt.AsEnumerable().Where(row => row.Field<string>("Usuario") == Username);

            if (filasFiltradas.Any())
            {
                return filasFiltradas.CopyToDataTable();
            }
            else
            {
                // Si NO hay resultados, devolvemos una tabla vacía.
                return dt.Clone();
            }
        }*/

    }
}