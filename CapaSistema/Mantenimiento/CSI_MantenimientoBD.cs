using CapaDatos;

namespace CapaSistema
{
    public class CSI_MantenimientoBD
    {
        CD_MantenimientoBD CD_MantenimientoBD = new CD_MantenimientoBD();

        public void RealizarBackUp()
        {
            CD_MantenimientoBD.RealizarBackUp();
        }
        public void RealizarRestauracion()
        {
            CD_MantenimientoBD.RealizarRestauracion();
        }
        public void RealizarMantenimientoIndices()
        {
            CD_MantenimientoBD.RealizarMantenimientoIndices();
        }
        public void RealizarReduccionLogs()
        {
            CD_MantenimientoBD.RealizarReduccionLogs();
        }

    }
}
