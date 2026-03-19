namespace CapaDatos
{
    public class CD_Preinscripciones : CD_EjecutarSP
    {
        private CD_EjecutarSP ejecutarSP = new CD_EjecutarSP();

        /*public void InsertarPreinscripciones(CD_DatosPreinscripciones Preinscripciones)
        {
            SqlParameter param = new SqlParameter("@IdPersona", Preinscripciones.IdPersona) { SqlDbType = SqlDbType.Int };
            SqlParameter param1 = new SqlParameter("@Apellido", Preinscripciones.Apellido) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@Nombre", Preinscripciones.Nombre) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@Genero", Preinscripciones.Genero) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@TipoDoc", Preinscripciones.TipoDoc) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param5 = new SqlParameter("@NumDoc", Preinscripciones.NumDoc) { SqlDbType = SqlDbType.Int };
            SqlParameter param6 = new SqlParameter("@FechaNac", Preinscripciones.FechaNac) { SqlDbType = SqlDbType.DateTime };
            SqlParameter param7 = new SqlParameter("@LugNacimiento", Preinscripciones.LugNacimiento) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param8 = new SqlParameter("@IdNacionalidad", Preinscripciones.IdNacionalidad) { SqlDbType = SqlDbType.Int };
            SqlParameter param9 = new SqlParameter("@IdProvincia", Preinscripciones.IdProvincia) { SqlDbType = SqlDbType.Int };
            SqlParameter param10 = new SqlParameter("@EstadoCivil", Preinscripciones.EstadoCivil) { SqlDbType = SqlDbType.Int };
            SqlParameter param11 = new SqlParameter("@CantHijos", Preinscripciones.CantHijos) { SqlDbType = SqlDbType.Int };
            SqlParameter param12 = new SqlParameter("@FamiliaresCargo", Preinscripciones.FamiliaresCargo) { SqlDbType = SqlDbType.Int };
            SqlParameter param13 = new SqlParameter("@IdPartido", Preinscripciones.IdPartido) { SqlDbType = SqlDbType.Int };
            SqlParameter param14 = new SqlParameter("@IdLocalidad", Preinscripciones.IdLocalidad) { SqlDbType = SqlDbType.Int };
            SqlParameter param15 = new SqlParameter("@Grupo", Preinscripciones.Grupo) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param16 = new SqlParameter("@CUIL", Preinscripciones.CUIL) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param17 = new SqlParameter("@IdSinDniARG", Preinscripciones.IdSinDniARG) { SqlDbType = SqlDbType.Int };
            // SqlParameter param18 = new SqlParameter("@IdSinDniARG", Preinscripciones.IdSinDniARG) { SqlDbType = SqlDbType.Int };
            SqlParameter param19 = new SqlParameter("@DocDescripOtros", Preinscripciones.DocDescripOtros) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param20 = new SqlParameter("@LetraDoc", Preinscripciones.LetraDoc) { SqlDbType = SqlDbType.VarChar };

            SqlParameter param21 = new SqlParameter("@IdInstitucion", Preinscripciones.IdInstitucion) { SqlDbType = SqlDbType.Int };
            SqlParameter param22 = new SqlParameter("@IdCarrera", Preinscripciones.IdCarrera) { SqlDbType = SqlDbType.Int };

            SqlParameter param23 = new SqlParameter("@DescTitulo", Preinscripciones.DescTituloSec) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param24 = new SqlParameter("@Escuela", Preinscripciones.Escuela) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param25 = new SqlParameter("@Completo", Preinscripciones.Completo) { SqlDbType = SqlDbType.Bit };
            SqlParameter param26 = new SqlParameter("@NoSecComp_NActa_AAdm", Preinscripciones.NoSecComp_NActa_AAdm) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param27 = new SqlParameter("@TipoTitulo", Preinscripciones.TipoTitulo) { SqlDbType = SqlDbType.Int };
            SqlParameter param28 = new SqlParameter("@Distrito", Preinscripciones.Distrito) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param29 = new SqlParameter("@YearEgreso", Preinscripciones.YearEgreso) { SqlDbType = SqlDbType.Int };

            SqlParameter param30 = new SqlParameter("@InstitucionEst", Preinscripciones.InstitucionEst) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param31 = new SqlParameter("@TipoTitulo", Preinscripciones.TipoTitulo) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param32 = new SqlParameter("@Grado", Preinscripciones.Grado) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param33 = new SqlParameter("@Titulo", Preinscripciones.Titulo) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param34 = new SqlParameter("@EgresoYear", Preinscripciones.EgresoYear) { SqlDbType = SqlDbType.Int };

            SqlParameter param35 = new SqlParameter("@Trabaja", Preinscripciones.Trabaja) { SqlDbType = SqlDbType.Bit };
            SqlParameter param36 = new SqlParameter("@Actividad", Preinscripciones.Actividad) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param37 = new SqlParameter("@Horario", Preinscripciones.Horario) { SqlDbType = SqlDbType.VarChar };

            SqlParameter param38 = new SqlParameter("@TieneObraSocial", Preinscripciones.TieneObraSocial) { SqlDbType = SqlDbType.Bit };
            SqlParameter param39 = new SqlParameter("@ObraSocial", Preinscripciones.ObraSocial) { SqlDbType = SqlDbType.VarChar };

            SqlParameter param40 = new SqlParameter("@CodArea", Preinscripciones.CodArea) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param41 = new SqlParameter("@Telefono", Preinscripciones.Telefono) { SqlDbType = SqlDbType.VarChar };

            SqlParameter param42 = new SqlParameter("@Mail", Preinscripciones.Mail) { SqlDbType = SqlDbType.VarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11,
            param12, param13, param14, param15, param16, param17, param19, param20, param21,param22, param23, param24, param25, param26, param27, param28, param29,
            param30, param31,param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42};
            EjecutarConsultas("sp1_updatePersona", listaParametros.ToArray(), false);
        }*/

        /*public DataTable ConsultarUsuarios()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_consPreinscripciones");
        }*/

        /*public void ModificarUsuario(CD_DatoUsuario usuario)
        {

        }*/

        /*public void BajaUsuario(CD_DatoUsuario usuario)
        {

        }*/
    }
}
