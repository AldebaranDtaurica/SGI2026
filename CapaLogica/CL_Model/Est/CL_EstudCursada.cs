using System;

namespace CapaLogica.CL_Model.Est
{
    public class CL_EstudCursada
    {
        public int IdCursada { get; set; }
        public int IdEstudios { get; set; }
        public int IdMateria { get; set; }
        public bool Equivalencia { get; set; }
        public string Seccion { get; set; }
        public bool Cursa { get; set; }
        public bool Libre { get; set; }
        public bool ParcialA { get; set; }
        public bool ParcialB { get; set; }
        public bool RecuperatirioInst { get; set; }
        public bool Promociona { get; set; }
        public DateTime FinCursada { get; set; }
    }
}
