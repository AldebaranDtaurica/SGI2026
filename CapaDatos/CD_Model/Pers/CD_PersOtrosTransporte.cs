using System;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersOtrosTransporte
    {
        public int IdPersOtrosTransporte { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool PieBici { get; set; }
        public bool Colectivo { get; set; }
        public bool Tren { get; set; }
        public bool VehiculoPart { get; set; }
        public bool TaxiRemis { get; set; }
        public bool Otro { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
