using CapaDatos.CD_Model.Pers;
using System.Data;

namespace CapaDatos
{
    public class CD_ValidacionPreinscripciones : CD_EjecutarSP
    {
        public readonly CD_PersEstudios estudios = new CD_PersEstudios();
        //public readonly
        /*public void ValidaPersEstudios(CD_PersEstudios estudios)
        {
            SqlParameter param1 = new SqlParameter("@IdEstudios", estudios.IdEstudios) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@IdPersona", estudios.IdPersona) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@ApeNom", estudios.ApeNom) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@TipoNumDoc", estudios.TipoNumDoc) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param5 = new SqlParameter("@IdInstitucion", estudios.IdInstitucion) { SqlDbType = SqlDbType.Int };
            SqlParameter param6 = new SqlParameter("@Institucion", estudios.Institucion) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param7 = new SqlParameter("@IdCarrera", estudios.IdCarrera) { SqlDbType = SqlDbType.Int };
            SqlParameter param8 = new SqlParameter("@Carrera", estudios.Carrera) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param9 = new SqlParameter("@AnioIngreso", estudios.AnioIngreso) { SqlDbType = SqlDbType.Int };
            SqlParameter param10 = new SqlParameter("@AnioEgreso", estudios.AnioEgreso) { SqlDbType = SqlDbType.Int };
            SqlParameter param11 = new SqlParameter("@Activo", estudios.Activo) { SqlDbType = SqlDbType.Bit };
            SqlParameter param12 = new SqlParameter("@UsrValida", estudios.UsrValida) { SqlDbType = SqlDbType.Int };
            SqlParameter param13 = new SqlParameter("@NumAsigSolicitud", estudios.NumAsigSolicitud) { SqlDbType = SqlDbType.Int };
            SqlParameter param14 = new SqlParameter("@NumLegajo", estudios.NumLegajo) { SqlDbType = SqlDbType.Int };
            SqlParameter param15 = new SqlParameter("@NumMatriz", estudios.NumMatriz) { SqlDbType = SqlDbType.Int };
            SqlParameter param16 = new SqlParameter("@NumFolio", estudios.NumFolio) { SqlDbType = SqlDbType.Int };
            SqlParameter param17 = new SqlParameter("@ListaEspera", estudios.ListaEspera) { SqlDbType = SqlDbType.Bit };
            SqlParameter param18 = new SqlParameter("@CopyDNI", estudios.CopyDNI) { SqlDbType = SqlDbType.Bit };
            SqlParameter param19 = new SqlParameter("@CopyTituloSec", estudios.CopyTituloSec) { SqlDbType = SqlDbType.Bit };
            SqlParameter param20 = new SqlParameter("@Foto", estudios.Foto) { SqlDbType = SqlDbType.Bit };
            SqlParameter param21 = new SqlParameter("@CertMedico", estudios.CertMedico) { SqlDbType = SqlDbType.Bit };
            SqlParameter param22 = new SqlParameter("@NroRegistro", estudios.NroRegistro) { SqlDbType = SqlDbType.Int };
            SqlParameter param23 = new SqlParameter("@Validado", estudios.Validado) { SqlDbType = SqlDbType.Bit };
            SqlParameter param24 = new SqlParameter("@ValidacionProvisoria", estudios.ValidacionProvisoria) { SqlDbType = SqlDbType.Bit };
            SqlParameter param25 = new SqlParameter("@Observaciones", estudios.Observaciones) { SqlDbType = SqlDbType.VarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>()
            {
                param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25
            };

            EjecutarConsultas("sp_UpdValidaPersEstudios", listaParametros.ToArray(), false);
        }*/

        public DataTable SelectValidaPersEstudios()
        {
            /*  SqlParameter param1 = new SqlParameter("@IdEstudios", estudios.IdEstudios) { SqlDbType = SqlDbType.Int };
              SqlParameter param2 = new SqlParameter("@IdPersona", estudios.IdPersona) { SqlDbType = SqlDbType.Int };
              SqlParameter param3 = new SqlParameter("@ApeNom", estudios.ApeNom) { SqlDbType = SqlDbType.VarChar };
              SqlParameter param4 = new SqlParameter("@TipoNumDoc", estudios.TipoNumDoc) { SqlDbType = SqlDbType.VarChar };
              SqlParameter param5 = new SqlParameter("@IdInstitucion", estudios.IdInstitucion) { SqlDbType = SqlDbType.Int };
              SqlParameter param6 = new SqlParameter("@Institucion", estudios.Institucion) { SqlDbType = SqlDbType.VarChar };
              SqlParameter param7 = new SqlParameter("@IdCarrera", estudios.IdCarrera) { SqlDbType = SqlDbType.Int };
              SqlParameter param8 = new SqlParameter("@Carrera", estudios.Carrera) { SqlDbType = SqlDbType.VarChar };
              SqlParameter param9 = new SqlParameter("@AnioIngreso", estudios.AnioIngreso) { SqlDbType = SqlDbType.Int };
              SqlParameter param10 = new SqlParameter("@AnioEgreso", estudios.AnioEgreso) { SqlDbType = SqlDbType.Int };
              SqlParameter param11 = new SqlParameter("@Activo", estudios.Activo) { SqlDbType = SqlDbType.Bit };
              SqlParameter param12 = new SqlParameter("@UsrValida", estudios.UsrValida) { SqlDbType = SqlDbType.Int };
              SqlParameter param13 = new SqlParameter("@NumAsigSolicitud", estudios.NumAsigSolicitud) { SqlDbType = SqlDbType.Int };
              SqlParameter param14 = new SqlParameter("@NumLegajo", estudios.NumLegajo) { SqlDbType = SqlDbType.Int };
              SqlParameter param15 = new SqlParameter("@NumMatriz", estudios.NumMatriz) { SqlDbType = SqlDbType.Int };
              SqlParameter param16 = new SqlParameter("@NumFolio", estudios.NumFolio) { SqlDbType = SqlDbType.Int };
              SqlParameter param17 = new SqlParameter("@ListaEspera", estudios.ListaEspera) { SqlDbType = SqlDbType.Bit };
              SqlParameter param18 = new SqlParameter("@CopyDNI", estudios.CopyDNI) { SqlDbType = SqlDbType.Bit };
              SqlParameter param19 = new SqlParameter("@CopyTituloSec", estudios.CopyTituloSec) { SqlDbType = SqlDbType.Bit };
              SqlParameter param20 = new SqlParameter("@Foto", estudios.Foto) { SqlDbType = SqlDbType.Bit };
              SqlParameter param21 = new SqlParameter("@CertMedico", estudios.CertMedico) { SqlDbType = SqlDbType.Bit };
              SqlParameter param22 = new SqlParameter("@NroRegistro", estudios.NroRegistro) { SqlDbType = SqlDbType.Int };
              SqlParameter param23 = new SqlParameter("@Validado", estudios.Validado) { SqlDbType = SqlDbType.Bit };
              SqlParameter param24 = new SqlParameter("@ValidacionProvisoria", estudios.ValidacionProvisoria) { SqlDbType = SqlDbType.Bit };
              SqlParameter param25 = new SqlParameter("@Observaciones", estudios.Observaciones) { SqlDbType = SqlDbType.VarChar };
            */
            //List<SqlParameter> listaParametros = new List<SqlParameter>()
            //{
            //    param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25
            // };

            return EjecutarConsultasSinParam("Select_ValidPersEstudios");
        }
    }
}
