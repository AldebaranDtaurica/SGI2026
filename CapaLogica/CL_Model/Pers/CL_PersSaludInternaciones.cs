using System;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersSaludInternaciones
    {
        public int IdPersSaludInternaciones { get; set; }
        public int IdPersona { get; set; }
        public bool IntComun { get; set; }
        public int IntComunCant { get; set; }
        public string IntComunDiag { get; set; }
        public bool IntInt { get; set; }
        public int IntIntCant { get; set; }
        public string IntIntDiag { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
