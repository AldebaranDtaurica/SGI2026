using System;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersSaludOperaciones
    {
        public int IdPersSaludOperaciones { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool TuvoOperac { get; set; }
        public string OperacDiagnostic { get; set; }
        public int Anio { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
