using System;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersSaludSituacion
    {
        public int IdPersSaludSituacion { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool AsmaBroncoespasmo { get; set; }
        public bool Falta_NoFunc_Organo { get; set; }
        public bool Celeaquia { get; set; }
        public bool EnfOncohematologica { get; set; }
        public bool CondCardiacas { get; set; }
        public bool Inmunodeficiencias { get; set; }
        public bool Frac_Lux_LesLigament { get; set; }
        public bool PresArterialElevada { get; set; }
        public bool ProbHuesoArtic { get; set; }
        public bool Convulsiones { get; set; }
        public bool TraumCraneo { get; set; }
        public bool Quemaduras { get; set; }
        public bool ProbPiel { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
