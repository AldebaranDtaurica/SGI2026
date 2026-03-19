using System;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersSaludDiscap
    {
        public int IdPersSaludDiscap { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool PoseeDisc { get; set; }
        public bool Aud_Hipoacusica_o { get; set; }
        public bool Aud_Sorda_o { get; set; }
        public bool Intelectual { get; set; }
        public bool Motora { get; set; }
        public bool Multiple { get; set; }
        public bool Neuromotora { get; set; }
        public bool Sordoceguera { get; set; }
        public bool TrastEmocionales { get; set; }
        public bool TrastEspLenguaje { get; set; }
        public bool Vis_Ciega_o { get; set; }
        public bool Vis_Disminuida_o { get; set; }
        public bool PoseeCUD { get; set; }
        public bool VigenteCUD { get; set; }
        public bool ReqAdecAcceso { get; set; }
        public string AdecuacionesReq { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
