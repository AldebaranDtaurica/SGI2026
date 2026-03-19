using System;

namespace CapaDatos.CD_Model.Inst
{
    public class CD_InstCarreras
    {
        public int IdCarrera { get; set; }
        public int IdInstitucion { get; set; }
        public string NombreCarrera { get; set; }
        public string PlanEstudio { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string InfoMail { get; set; }
        public string InfoTel { get; set; }
        public string Turno { get; set; }
    }
}
