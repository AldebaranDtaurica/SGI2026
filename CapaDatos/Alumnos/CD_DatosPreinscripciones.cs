using System;

namespace CapaDatos
{
    public class CD_DatosPreinscripciones
    {

        // Propiedades de la clase (mismo que antes)
        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public int TipoDoc { get; set; }
        public int IdSinDniARG { get; set; }
        public string DocDescripOtros { get; set; }
        public int NumDoc { get; set; }
        public string LetraDoc { get; set; }
        public string CUIL { get; set; }
        public DateTime FechaNac { get; set; }
        public string LugNacimiento { get; set; }
        public int IdNacionalidad { get; set; }
        public int IdProvincia { get; set; }
        public int IdPartido { get; set; }
        public int IdLocalidad { get; set; }
        public int EstadoCivil { get; set; }
        public int CantHijos { get; set; }
        public int FamiliaresCargo { get; set; }
        public string Grupo { get; set; } //1
        public int IdInstitucion { get; set; }
        public int IdCarrera { get; set; }//2
        public string DescTituloSec { get; set; }
        public string Escuela { get; set; }
        public bool Completo { get; set; }
        public string NoSecComp_NActa_AAdm { get; set; }
        public string Distrito { get; set; }
        public int YearEgreso { get; set; }//3
        public string InstitucionEst { get; set; }
        public string TipoTitulo { get; set; }
        public string Grado { get; set; }
        public string Titulo { get; set; }
        public int EgresoYear { get; set; }//4
        public bool Trabaja { get; set; }
        public string Actividad { get; set; }
        public string Horario { get; set; }//5
        public string ObraSocial { get; set; }
        public bool TieneObraSocial { get; set; }
        public string NumAfiliadoOS { get; set; }//6
        public string CodArea { get; set; }
        public string Telefono { get; set; }//7
        public string Mail { get; set; }//8
    }
}
