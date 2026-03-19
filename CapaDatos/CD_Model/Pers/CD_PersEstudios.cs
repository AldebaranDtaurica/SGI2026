namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersEstudios
    {
        public int IdEstudios { get; set; }
        public int IdPersona { get; set; }
        public string ApeNom { get; set; } //+
        public string TipoNumDoc { get; set; } //+
        public int IdInstitucion { get; set; }
        public string Institucion { get; set; } //+
        public int IdCarrera { get; set; }
        public string Carrera { get; set; } //+
        public int AnioIngreso { get; set; }
        public int AnioEgreso { get; set; }
        public bool Activo { get; set; }
        public int UsrValida { get; set; }
        public int NumAsigSolicitud { get; set; }
        public int NumLegajo { get; set; }
        public int NumMatriz { get; set; }
        public int NumFolio { get; set; }
        public bool ListaEspera { get; set; }
        public bool CopyDNI { get; set; }
        public bool CopyTituloSec { get; set; }
        public bool Foto { get; set; }
        public bool CertMedico { get; set; }
        public int NroRegistro { get; set; }
        public bool Validado { get; set; }
        public bool ValidacionProvisoria { get; set; }
        public string Observaciones { get; set; }
    }
}
