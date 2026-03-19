using System;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_Persona
    {
        public int Idpersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public int TipoDoc { get; set; }
        public string LetraDoc { get; set; }
        public int NumDoc { get; set; }
        public DateTime FechaNac { get; set; }
        public string LugNacimiento { get; set; }
        public int IdNacionalidad { get; set; }
        public int IdProvincia { get; set; }
        public int EstadoCivil { get; set; }
        public int CantHijos { get; set; }
        public int FamiliaresCargo { get; set; }
        public string Grupo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public DateTime FechaMod { get; set; }
        public string CUIL { get; set; }
        public int IdSinDniARG { get; set; }
        public string DocDescripOtros { get; set; }
    }
}
