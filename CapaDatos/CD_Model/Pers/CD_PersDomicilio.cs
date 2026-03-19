namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersDomicilio
    {
        public int IdPersDomicilio { get; set; }
        public int IdPersona { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Torre { get; set; }
        public string Depto { get; set; }
        public string Provincia { get; set; }
        public string Partido { get; set; }
        public string Localidad { get; set; }
        public string EntreCalleA { get; set; }
        public string EntreCalleB { get; set; }
        public string OtroDato { get; set; }
        public bool Activo { get; set; }
        public string CP { get; set; }

    }
}
