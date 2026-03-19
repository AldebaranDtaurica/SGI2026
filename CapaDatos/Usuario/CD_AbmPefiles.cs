using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{

    public class CD_AbmPerfiles : CD_EjecutarSP
    {
        // Método para Alta de Perfil
        public void AltaPerfil(string nombrePerfil, string descripcion, List<int> permisos, int idUser)
        {
            SqlParameter param1 = new SqlParameter("@nombre", nombrePerfil) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@descripcion", descripcion) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@idUser", idUser) { SqlDbType = SqlDbType.Int };  // Nuevo parámetro para el usuario
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

            // Ejecutar el SP y obtener el ID del perfil recién insertado
            DataTable dt = EjecutarConsultas("sp_altaPerfil", listaParametros.ToArray(), false);

            if (dt.Rows.Count > 0)
            {
                int perfilId = Convert.ToInt32(dt.Rows[0]["perfilId"]);

                // Ahora asignamos los permisos utilizando el mismo idUser
                AsignarPermisos(perfilId, permisos, idUser);
            }
            else
            {
                throw new Exception("No se pudo obtener el ID del perfil.");
            }
        }


        // Método para Asignar Permisos a un Perfil
        public void AsignarPermisos(int perfilId, List<int> permisos, int idUser)
        {
            foreach (var permisoId in permisos)
            {
                SqlParameter param1 = new SqlParameter("@perfilId", perfilId) { SqlDbType = SqlDbType.Int };
                SqlParameter param2 = new SqlParameter("@permisoId", permisoId) { SqlDbType = SqlDbType.Int };
                SqlParameter param3 = new SqlParameter("@idUser", idUser) { SqlDbType = SqlDbType.Int };  // Nuevo parámetro para el usuario
                List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

                // Ejecutar el SP para asignar el permiso
                EjecutarConsultas("sp_asignarPermisos", listaParametros.ToArray(), true);
            }
        }


        // Método para Desasignar Permisos de un Perfil
        public void DesasignarPermisos(int perfilId, List<int> permisos, int idUser)
        {
            foreach (var permisoId in permisos)
            {
                SqlParameter param1 = new SqlParameter("@perfilId", perfilId) { SqlDbType = SqlDbType.Int };
                SqlParameter param2 = new SqlParameter("@permisoId", permisoId) { SqlDbType = SqlDbType.Int };
                SqlParameter param3 = new SqlParameter("@idUser", idUser) { SqlDbType = SqlDbType.Int };  // Nuevo parámetro para el usuario
                List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

                // Ejecutar el SP para desasignar el permiso
                EjecutarConsultas("sp_desasignarPermisos", listaParametros.ToArray(), true);
            }
        }


        // Método para Baja de un Perfil
        public void BajaPerfil(int perfilId, int idUser)
        {
            SqlParameter param1 = new SqlParameter("@idPerfil", perfilId) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@idUser", idUser) { SqlDbType = SqlDbType.Int };  // Nuevo parámetro para el usuario
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

            // Ejecutar el SP para dar de baja al perfil
            EjecutarConsultas("sp_bajaPerfil", listaParametros.ToArray(), true);
        }

        public DataTable ConsultarPerfiles(bool conBajas)
        {
            DataTable dt = new DataTable();
            try
            {
                // Definimos el parámetro necesario para la consulta
                SqlParameter param1 = new SqlParameter("@conBajas", conBajas ? 1 : 0) { SqlDbType = SqlDbType.Int };
                List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

                // Ejecutamos la consulta usando el procedimiento almacenado "sp_consultarPerfiles"
                dt = EjecutarConsultas("sp_consultarPerfiles", listaParametros.ToArray(), false);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar perfiles", ex);
            }
            return dt;
        }

        public DataTable ConsultarPermisosLst()
        {
            DataTable dt = new DataTable();
            try
            {
                // Definimos el parámetro necesario para la consulta
                SqlParameter param1 = new SqlParameter("@baja", 0) { SqlDbType = SqlDbType.Int }; // Solo permisos activos
                List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

                // Ejecutamos la consulta usando el procedimiento almacenado "sp_consultarPermisos"
                dt = EjecutarConsultas("sp_consultarPermisos", listaParametros.ToArray(), false);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar permisos", ex);
            }
            return dt;
        }

        public DataTable ConsultarFamiliaPermisos(string Familia)
        {
            DataTable dt = new DataTable();
            try
            {
                // Definimos el parámetro necesario para la consulta
                SqlParameter param1 = new SqlParameter("@Familia", Familia) { SqlDbType = SqlDbType.VarChar }; // Solo permisos activos
                List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

                // Ejecutamos la consulta usando el procedimiento almacenado "sp_consultarPermisos"
                dt = EjecutarConsultas("sp_select_BoxRolFamilia", listaParametros.ToArray(), false);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar familia", ex);
            }
            return dt;
        }

    }
}
