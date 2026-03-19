using System;

namespace CapaLogica.CL_Model.Inst
{
    public class CL_Institucion
    {
        public int IdInstitucion { get; set; }
        public string NombreInstitucion { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string InfoMail { get; set; }
        public string InfoTel { get; set; }
        public int Numero { get; set; }
        public string Distrito { get; set; }
        public bool GestEstatal { get; set; }
        public string ClaveProvincial { get; set; }
        public string CUE { get; set; }
    }
}
