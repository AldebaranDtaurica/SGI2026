using CapaDatos.CD_Model.Pers;
using CapaSesion;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersSaludEjercicio
    {
        //public int IdPersSaludEjercicio { get; set; }
        //public int IdPersona { get; set; }
        //public bool Activo { get; set; }
        public bool Desmayo { get; set; }
        public bool MayorCansancioQ { get; set; }
        public bool DolorPecho { get; set; }
        public bool Palpitaciones { get; set; }
        public bool Mareos { get; set; }
        public bool DifRespirarActFisic { get; set; }
        //public DateTime Fecha { get; set; }
        public string Usuario { get; set; }


        public void GuardarDatos(CL_PersSaludEjercicio persSaludEjercicio)
        {
            Usuario = CSE_UserCache.IdUser.ToString();
            //CD_PersSaludEjercicio cdPersSaludEjercicio = new CD_PersSaludEjercicio();

            // Preparar el objeto para la capa de datos
            var cdPersSaludEjercicio = new CD_PersSaludEjercicio
            {
                Desmayo = Desmayo,
                Palpitaciones = Palpitaciones,
                MayorCansancioQ = MayorCansancioQ,
                DolorPecho = DolorPecho,
                Mareos = Mareos,
                DifRespirarActFisic = DifRespirarActFisic,
                Usuario = CSE_UserCache.IdUser.ToString()
            };

            cdPersSaludEjercicio.Guardar(cdPersSaludEjercicio);
        }


    }


}
