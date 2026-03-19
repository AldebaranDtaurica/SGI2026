using System;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersOtrosDatos
    {
        public int IdPersOtrosDatos { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool LenguaDifCastellano { get; set; }
        public bool LenguaIndigena { get; set; }
        public bool LenguaOtras { get; set; }
        public bool PueblosOriginarios { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
