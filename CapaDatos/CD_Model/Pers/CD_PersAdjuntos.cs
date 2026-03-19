namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersAdjuntos
    {
        public int IdAdjuntos { get; set; }
        public int IdPersona { get; set; }
        public int IdCategoria { get; set; }
        public string NombreAdj { get; set; }
        public string Extension { get; set; }
        public bool Activo { get; set; }
        public string Estado { get; set; }
        public string Path { get; set; }
    }
}
