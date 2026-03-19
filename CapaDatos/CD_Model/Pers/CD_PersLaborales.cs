using System;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersLaborales
    {
        public int IdLaborales { get; set; }
        public int IdPersona { get; set; }
        public string Empresa { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public bool Activo { get; set; }
        public bool Trabaja { get; set; }
        public string Actividad { get; set; }
        public string Horario_Habitual { get; set; }
    }
}
