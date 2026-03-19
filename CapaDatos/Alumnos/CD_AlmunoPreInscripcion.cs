using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{

    public class CD_AlmunoPreInscripcion : CD_Conexion
    {
        public void InsertarPreinscripciones(CD_DatosPreinscripciones datos)
        {
            using (SqlConnection connection = GetConnection())
            {
                string currentStoredProcedure = null;
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        currentStoredProcedure = "sp_pe_updIns_inscripcionPersona";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@Apellido", datos.Apellido);
                            command.Parameters.AddWithValue("@Nombre", datos.Nombre);
                            command.Parameters.AddWithValue("@Genero", datos.Genero);
                            command.Parameters.AddWithValue("@TipoDoc", datos.TipoDoc);
                            command.Parameters.AddWithValue("@IdSinDniARG", datos.IdSinDniARG);
                            command.Parameters.AddWithValue("@DocDescripOtros", datos.DocDescripOtros);
                            command.Parameters.AddWithValue("@NumDoc", datos.NumDoc);
                            command.Parameters.AddWithValue("@LetraDoc", datos.LetraDoc);
                            command.Parameters.AddWithValue("@CUIL", datos.CUIL);
                            command.Parameters.AddWithValue("@FechaNac", datos.FechaNac);
                            command.Parameters.AddWithValue("@LugNacimiento", datos.LugNacimiento);
                            command.Parameters.AddWithValue("@IdNacionalidad", datos.IdNacionalidad);
                            command.Parameters.AddWithValue("@IdProvincia", datos.IdProvincia);
                            command.Parameters.AddWithValue("@EstadoCivil", datos.EstadoCivil);
                            command.Parameters.AddWithValue("@CantHijos", datos.CantHijos);
                            command.Parameters.AddWithValue("@FamiliaresCargo", datos.FamiliaresCargo);
                            command.Parameters.AddWithValue("@Grupo", datos.Grupo);
                            command.Parameters.AddWithValue("@IdPartido", datos.IdPartido);
                            command.Parameters.AddWithValue("@IdLocalidad", datos.IdLocalidad);

                            // Agregar parámetro de salida para @IdPersona
                            //SqlParameter outputIdPersona = new SqlParameter("@IdPersona", SqlDbType.Int)
                            //    {
                            //         Direction = ParameterDirection.Output
                            //    };
                            // command.Parameters.Add(outputIdPersona);
                            command.ExecuteNonQuery();
                            // datos.IdPersona = (int)outputIdPersona.Value;
                        }

                        currentStoredProcedure = "sp_pe_updIns_insertPersEstudios";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@IdInstitucion", datos.IdInstitucion);
                            command.Parameters.AddWithValue("@IdCarrera", datos.IdCarrera);
                            command.ExecuteNonQuery();
                        }

                        currentStoredProcedure = "sp_pe_updIns_insertPersIngresoTitulo";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@Titulo", datos.Titulo);
                            command.Parameters.AddWithValue("@Completo", datos.Completo);
                            command.Parameters.AddWithValue("@NoSecComp_NActa_AAdm", datos.NoSecComp_NActa_AAdm);
                            command.Parameters.AddWithValue("@TipoTitulo", datos.TipoTitulo);
                            command.Parameters.AddWithValue("@Distrito", datos.Distrito);
                            command.Parameters.AddWithValue("@YearEgreso", datos.YearEgreso);
                            command.ExecuteNonQuery();
                        }

                        currentStoredProcedure = "sp_pe_updIns_insertPersIngresoTitulo2";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@Titulo", datos.Titulo);
                            command.Parameters.AddWithValue("@Grado", datos.Grado);
                            command.Parameters.AddWithValue("@InstitucionEst", datos.InstitucionEst);
                            command.Parameters.AddWithValue("@EgresoYear", datos.EgresoYear);
                            command.ExecuteNonQuery();
                        }

                        currentStoredProcedure = "sp_pe_updIns_insertPersLaborales";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@Trabaja", datos.Trabaja);
                            command.Parameters.AddWithValue("@Actividad", datos.Actividad);
                            command.Parameters.AddWithValue("@Horario", datos.Horario);
                            command.ExecuteNonQuery();
                        }

                        currentStoredProcedure = "sp_pe_updIns_insertPersSaludObSocial";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@TieneObraSocial", datos.TieneObraSocial);
                            command.Parameters.AddWithValue("@ObraSocial", datos.ObraSocial);
                            command.Parameters.AddWithValue("@NumAfiliadoOS", datos.NumAfiliadoOS);
                            command.ExecuteNonQuery();
                        }

                        currentStoredProcedure = "sp_pe_updIns_insertPersContacto";
                        using (SqlCommand command = new SqlCommand(currentStoredProcedure, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdPersona", datos.IdPersona);
                            command.Parameters.AddWithValue("@Telefono", datos.Telefono);
                            command.Parameters.AddWithValue("@CodArea", datos.CodArea);
                            command.Parameters.AddWithValue("@Mail", datos.Mail);
                            command.ExecuteNonQuery();
                        }

                        // Si todo se ejecutó correctamente, confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // En caso de error, revertir la transacción
                        transaction.Rollback();
                        throw new Exception($"Error al ejecutar el procedimiento almacenado '{currentStoredProcedure}': {ex.Message}", ex);
                    }
                }
            }
        }
    }
}