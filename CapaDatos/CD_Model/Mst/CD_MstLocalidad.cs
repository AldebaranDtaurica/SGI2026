namespace CapaDatos.CD_Model.Mst
{
    public class CD_MstLocalidad
    {
        public int IdLocalidad { get; set; }
        public int IdPartido { get; set; }
        public string Localidad { get; set; }
        public string CodPostal { get; set; }
        public bool Activo { get; set; }
    }
}
