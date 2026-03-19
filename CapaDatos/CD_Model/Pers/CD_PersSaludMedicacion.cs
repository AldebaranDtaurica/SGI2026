using System;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersSaludMedicacion
    {
        public int IdPersSaludMedicacion { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool MedicacHabitual { get; set; }
        public string MedicacDescripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
