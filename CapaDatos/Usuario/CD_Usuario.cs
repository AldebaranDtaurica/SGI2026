using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario : CD_EjecutarSP
    {

        public void InsertarUsuario(CD_DatoUsuario usuario)
        {
            SqlParameter param1 = new SqlParameter("@Apellido", usuario.Apellido) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@Nombre", usuario.Nombre) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@TipoDocumento", usuario.TipoDocumento) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@NumeroDocumento", usuario.NumeroDocumento) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param5 = new SqlParameter("@Email", usuario.Email) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param6 = new SqlParameter("@Grupo", usuario.Grupo) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param7 = new SqlParameter("@Familia", usuario.Familia) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param8 = new SqlParameter("@Username", usuario.Username) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param9 = new SqlParameter("@DiasCambioClave", usuario.DiasCambioClave) { SqlDbType = SqlDbType.Int };
            SqlParameter param10 = new SqlParameter("@Passkey", usuario.Passkey) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param11 = new SqlParameter("@DigitPass", usuario.DigitPass) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11 };
            EjecutarConsultas("sp_insertUsuario", listaParametros.ToArray(), false);
        }

        public DataTable ConsultarUsuarios()//string usuario) //List<CD_Usuario>
        {
            return EjecutarConsultasSinParam("sp_consUsuarios");
        }

        //public DataTable ConsultarUsuarios()
        //{
        //    return EjecutarConsultasSinParam("sp_consUsuarios");
        // }

        /*public DataTable PermisosUsuarios()
        {
            return EjecutarConsultasSinParam("sp_permisoUsuarios");
        }

        public DataTable FamiliaUsuarios()
        {
            return EjecutarConsultasSinParam("sp_permisoUsuarios");
        }*/

        public void ModificarUsuarioPass(CD_DatoUsuario usuario)
        {
            try
            {
                SqlParameter param1 = new SqlParameter("@Username", usuario.Username) { SqlDbType = SqlDbType.VarChar };
                SqlParameter param2 = new SqlParameter("@Passkey", usuario.Passkey) { SqlDbType = SqlDbType.VarChar };
                SqlParameter param3 = new SqlParameter("@DigitPass", usuario.DigitPass) { SqlDbType = SqlDbType.NVarChar };
                SqlParameter param4 = new SqlParameter("@Recupero", usuario.Recupero) { SqlDbType = SqlDbType.Bit };
                List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };
                EjecutarConsultas("sp_updPassUsuario", listaParametros.ToArray(), true);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar: " + ex.Message);
            }
        }

        public void BajaUsuario(CD_DatoUsuario usuario)
        {

        }

        public void RecuperoUsuario(CD_DatoUsuario usuario)
        {
            SqlParameter param1 = new SqlParameter("@Username", usuario.Username) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@DiasCambioClave", usuario.DiasCambioClave) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@Passkey", usuario.Passkey) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@DigitPass", usuario.DigitPass) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };
            EjecutarConsultas("sp_updRecuperoUsuario", listaParametros.ToArray(), false);
        }

        public void RecuperoUsuarioBit(CD_DatoUsuario usuario)
        {
            SqlParameter param1 = new SqlParameter("@Username", usuario.Username) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@Recupero", usuario.Recupero) { SqlDbType = SqlDbType.Bit };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            EjecutarConsultas("sp_updRecuperoUsuarioBit", listaParametros.ToArray(), false);
        }
    }
}