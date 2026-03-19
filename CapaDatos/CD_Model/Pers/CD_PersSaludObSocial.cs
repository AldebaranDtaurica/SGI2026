namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersSaludObSocial
    {
        public int IdPersSaludObSocial { get; set; }
        public int IdPersona { get; set; }
        public bool PoseeOS { get; set; }
        public string DescripcionOS { get; set; }
        public string NumAfiliadoOS { get; set; }
    }
}
