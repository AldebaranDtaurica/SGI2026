using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EjecutarSP : CD_Conexion
    {
        public DataTable EjecutarConsultas(string NombreSP, SqlParameter[] sqlParameters, bool Directa = false)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection CNN = GetConnection())
                {
                    CNN.Open();
                    using (SqlCommand comando = new SqlCommand(NombreSP, CNN))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddRange(sqlParameters);
                        if (!Directa)
                        {
                            DT.Load(comando.ExecuteReader());
                        }
                        else
                        {
                            comando.ExecuteNonQuery();
                        }
                    }
                    CNN.Close();
                }
                return DT;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado o Conexion a la Base de Datos. \n \n" + ex.Message);
            }
            finally
            {

            }
        }

        public DataTable EjecutarConsultasSinParam(string NombreSP, bool Directa = false)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection CNN = GetConnection())
                {
                    CNN.Open();
                    using (SqlCommand comando = new SqlCommand(NombreSP, CNN))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        if (!Directa)
                        {
                            DT.Load(comando.ExecuteReader()); // VERIFICAR SI SE DEBE CARGAR A DT
                            //List<CD_Usuario> listaUsuarios = new List<CD_Usuario>();
                            //listaUsuarios = comando.ExecuteNonQuery().Cast<CD_Usuario>().ToList();
                        }
                        else
                        {
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                return DT;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado o Conexion a la Base de Datos. \n \n" + ex.Message);
            }
            finally
            {

            }
        }

        public DataTable EjecutarConsultasSinParamMas(string NombreSP, bool Directa = false)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection CNN = GetConnectionMas())
                {
                    CNN.Open();
                    using (SqlCommand comando = new SqlCommand(NombreSP, CNN))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        if (!Directa)
                        {
                            DT.Load(comando.ExecuteReader());
                        }
                        else
                        {
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                return DT;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado o Conexion a la Base de Datos. \n \n" + ex.Message);
            }
            finally
            {

            }
        }


        /*public DataTable SelectPreguntas(int IdUser)
        {
            SqlParameter param1 = new SqlParameter("@usuario", IdUser) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioPermisos", listaParametros.ToArray());
            return resultado;
        }*/
    }
}