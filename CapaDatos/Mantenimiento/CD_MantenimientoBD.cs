namespace CapaDatos
{
    public class CD_MantenimientoBD : CD_EjecutarSP
    {
        public void RealizarBackUp()
        {
            EjecutarConsultasSinParam("sp_DB_SGInst_Backup2");
        }

        public void RealizarMantenimientoIndices()
        {
            EjecutarConsultasSinParam("sp_DB_SGInst_MantIndices");
        }

        public void RealizarReduccionLogs()
        {
            EjecutarConsultasSinParam("sp_DB_SGInst_ReducirLog");
        }

        public void RealizarRestauracion()
        {
            EjecutarConsultasSinParamMas("sp_DB_SGInst_MasterRestore2");
        }
    }
}