using CapaDatos.CD_Model.Pers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;


namespace CapaDatos.Usuario
{
    public class CD_Roles : CD_EjecutarSP
    {


        public DataTable ConsultarRol(int IdPersona)
        {
            SqlParameter param1 = new SqlParameter("@IdPersona", IdPersona) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioRol", listaParametros.ToArray()); //OK: Traer datos de usuario
            return resultado;
        }

        public bool ActualizarRolesUsuario(DataTable dtRoles, int idUsuario)
        {
            try
            {
                foreach (DataRow row in dtRoles.Rows)
                {
                    // Solo insertamos si la fila no está marcada como borrada
                    if (row.RowState != DataRowState.Deleted)
                    {
                        List<SqlParameter> parametros = new List<SqlParameter>();

                        parametros.Add(new SqlParameter("@idUsuario", idUsuario));
                        parametros.Add(new SqlParameter("@idRol", row["IdRol"]));

                        // Manejo de la fecha de baja (si es NULL en el DataTable, mandamos DBNull al SQL)
                        object fechaBaja = row["BajaProgramada"] == DBNull.Value ?
                                           (object)DBNull.Value :
                                           Convert.ToDateTime(row["BajaProgramada"]);

                        parametros.Add(new SqlParameter("@BajaProgramada", fechaBaja));

                        // Ejecutamos el SP de inserción para cada rol
                        EjecutarConsultas("sp_GuardarRolUsuario", parametros.ToArray(), true);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Capa de Datos al actualizar roles: " + ex.Message);
            }
        }

        public bool GuardarAsignacionesPP(DataTable dtAsignacionesPP, int idPersona, string familia, bool condicion)
        {
            try
            {
                if (familia  == "PROFESORES") 
                {
                    foreach (DataRow row in dtAsignacionesPP.Rows)
                    {
                        // Solo insertamos si la fila no está marcada como borrada
                        if (row.RowState != DataRowState.Deleted)
                        {
                            List<SqlParameter> parametros = new List<SqlParameter>();

                            parametros.Add(new SqlParameter("@condicion", condicion));
                            parametros.Add(new SqlParameter("@familia", familia));
                            parametros.Add(new SqlParameter("@idPersona", idPersona));
                            parametros.Add(new SqlParameter("@IdMateria", row["IdMateria"]));
                            parametros.Add(new SqlParameter("@Carrera", row["Carrera"]));
                            parametros.Add(new SqlParameter("@Año", row["Año"]));
                            parametros.Add(new SqlParameter("@Division", row["Division"]));
                            parametros.Add(new SqlParameter("@Asignado", row["Asignado"]));
                            // Ejecutamos el SP de inserción para cada rol
                            EjecutarConsultas("Update_AsignacionProfesorPreceptor", parametros.ToArray(), true);
                        }
                    }
                    return true;
                }
                else
                    {
                        foreach (DataRow row in dtAsignacionesPP.Rows)
                        {
                    // Solo insertamos si la fila no está marcada como borrada
                        if (row.RowState != DataRowState.Deleted)
                        {
                            List<SqlParameter> parametros = new List<SqlParameter>();

                            parametros.Add(new SqlParameter("@condicion", condicion));
                            parametros.Add(new SqlParameter("@familia", familia));
                            parametros.Add(new SqlParameter("@idPersona", idPersona));
                            parametros.Add(new SqlParameter("@IdDivision", row["IdCarreraDivision"]));
                            parametros.Add(new SqlParameter("@Asignado", row["Asignado"]));

                            // Manejo de la fecha de baja (si es NULL en el DataTable, mandamos DBNull al SQL)
                            // object fechaBaja = row["BajaProgramada"] == DBNull.Value ?
                            // (object)DBNull.Value :
                            //  Convert.ToDateTime(row["BajaProgramada"]);

                            // parametros.Add(new SqlParameter("@BajaProgramada", fechaBaja));

                            // Ejecutamos el SP de inserción para cada rol
                            EjecutarConsultas("Update_AsignacionProfesorPreceptor", parametros.ToArray(), true);
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Capa de Datos al actualizar Asignaciones: " + ex.Message);
            }
        }

    }
}
