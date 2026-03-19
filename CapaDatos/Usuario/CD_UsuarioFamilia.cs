using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_UsuarioFamilia : CD_EjecutarSP
    {
        public List<CD_DatosUsuarioFamilia> ConsultarFamilia(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioFamilia", listaParametros.ToArray());

            List<CD_DatosUsuarioFamilia> listaFamilia = new List<CD_DatosUsuarioFamilia>();
            foreach (DataRow row in resultado.Rows)
            {
                CD_DatosUsuarioFamilia datosUsuarioFamilia = new CD_DatosUsuarioFamilia
                {
                    //Username = row["Username"].ToString(),
                    Fdescripcion = row["Fdescripcion"].ToString()
                };
                listaFamilia.Add(datosUsuarioFamilia);
            }
            return listaFamilia;
        }

        /*public DataTable ConsultarFamiliasVarias(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioFamilia", listaParametros.ToArray());
            return resultado;
        }*/
    }
}

/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using CapaSesion;

namespace CapaDatos
{
    public class CD_UsuarioFamilia2 : CD_EjecutarSP
    {
        public List<CD_DatosUsuarioFamilia> ConsultarFamilia2(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.VarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("sp_consultarUsuarioFamilia", listaParametros.ToArray());

            List<CD_DatosUsuarioFamilia> listaFamilia = new List<CD_DatosUsuarioFamilia>();
            foreach (DataRow row in resultado.Rows)
            {
                CD_DatosUsuarioFamilia datosUsuarioFamilia = new CD_DatosUsuarioFamilia
                {
                    Fdescripcion = row["Fdescripcion"].ToString()
                };
                listaFamilia.Add(datosUsuarioFamilia);
            }
            return listaFamilia;
        }
    }
}
*/