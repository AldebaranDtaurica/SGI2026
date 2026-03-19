namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersIngresoTitulo
    {
        public int IdIngTitulo { get; set; }
        public string DescTitulo { get; set; }
        public bool Completo { get; set; }
        public string NoSecComp_NActa_AAdm { get; set; }
        public int AnioIngreso { get; set; }
        public string TipoTitulo { get; set; }
        public string Intitucion { get; set; }
        public string Distrito { get; set; }
        public string PlanEstudResol { get; set; }
        public int IdEstudios { get; set; }
        public int FechaEgreso { get; set; } //DateTime?
    }
}
