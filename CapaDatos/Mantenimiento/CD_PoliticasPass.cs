using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_PoliticasPass : CD_EjecutarSP
    {
        public void ActualizarConfiguraciones(List<Tuple<int, bool>> configuraciones)
        {
            foreach (var config in configuraciones)
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                        new SqlParameter("@IdPol", SqlDbType.Int) { Value = config.Item1 },
                        new SqlParameter("@Activo", SqlDbType.Bit) { Value = config.Item2 }
                };

                EjecutarConsultas("sp_updatePoliticaPass", parameters, false);
            }
        }

        private CD_EjecutarSP ejecutarSP = new CD_EjecutarSP();
        public DataTable ConsultarConfiguraciones()
        {
            // Llamamos al método que no necesita parámetros
            return ejecutarSP.EjecutarConsultasSinParam("sp_consPoliticaPass");
        }
    }


}
