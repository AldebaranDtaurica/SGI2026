using System;

namespace CapaDatos.CD_Model.Est
{
    public class CD_EstudFinal
    {
        public int IdFinal { get; set; }
        public int IdCursada { get; set; }
        public bool Equivalencia { get; set; }
        public string Dictamen { get; set; }
        public DateTime InscripcionFinal { get; set; }
        public DateTime AsistenciaFinal { get; set; }
        public int NotaFinal { get; set; }
        public int FolioFina { get; set; }
        public int TomoFinal { get; set; }
        public int LLamado { get; set; }
    }
}
