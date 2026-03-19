namespace CapaLogica.CL_Model.Inst
{
    public class CL_InstMateria
    {
        public int IdMateria { get; set; }
        public int IdCarrera { get; set; }
        public int Nivel { get; set; }
        public string NombreMateria { get; set; }
        public bool Activo { get; set; }
        public bool RendirLibre { get; set; }
        public bool Promocionable { get; set; }
        public int Codigo { get; set; }
        public int Horas { get; set; }
    }
}
