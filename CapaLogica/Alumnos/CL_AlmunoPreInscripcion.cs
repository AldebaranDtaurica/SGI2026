using CapaDatos;
using CapaSesion;
using System;

namespace CapaLogica
{
    public class CL_AlmunoPreInscripcion
    {
        // public int? IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public int TipoDoc { get; set; }
        public int IdSinDniARG { get; set; }
        public string DocDescripOtros { get; set; }
        public int NumDoc { get; set; }
        public string LetraDoc { get; set; } //alter varchar
        public string CUIL { get; set; }
        public DateTime FechaNac { get; set; }
        public string LugNacimiento { get; set; }
        public int IdNacionalidad { get; set; }
        public int IdProvincia { get; set; }
        public int IdPartido { get; set; }
        public int IdLocalidad { get; set; }
        public int EstadoCivil { get; set; }
        public int CantHijos { get; set; }
        public int FamiliaresCargo { get; set; } //pasar a int
        public string Grupo { get; set; }

        public int IdInstitucion { get; set; }
        public int IdCarrera { get; set; }

        public string DescTituloSec { get; set; }
        public string Escuela { get; set; }
        public bool Completo { get; set; }
        public string NoSecComp_NActa_AAdm { get; set; }
        public string Distrito { get; set; }
        public int YearEgreso { get; set; }

        public string InstitucionEst { get; set; }
        public string TipoTitulo { get; set; }
        public string Grado { get; set; }
        public string Titulo { get; set; }
        public int EgresoYear { get; set; }

        public bool Trabaja { get; set; }
        public string Actividad { get; set; }
        public string Horario { get; set; }

        public string ObraSocial { get; set; }
        public bool TieneObraSocial { get; set; }
        public string NumAfiliadoOS { get; set; }


        public string CodArea { get; set; }
        public string Telefono { get; set; }

        public string Mail { get; set; }



        CL_Usuario cL_Usuario = new CL_Usuario();
        // Constructor para inicializar todos los campos
        public CL_AlmunoPreInscripcion(
            string apellido, string nombre, int genero, int tipoDoc, int idSinDniARG,
            string docDescripOtros, int numDoc, string letraDoc, string cuil, DateTime fechaNac,
            string lugNacimiento, int idNacionalidad, int idProvincia, int idPartido,
            int idLocalidad, int estadoCivil, int cantHijos, int familiaresCargo,
            string grupo, int idInstitucion, int idCarrera, string descTituloSec,
            string escuela, bool completo, string noSecComp_NActa_AAdm, string distrito,
            int yearEgreso, string institucionEst, string tipoTitulo, string grado,
            string titulo, int egresoYear, bool trabaja, string actividad, string horario,
            string obraSocial, bool tieneObraSocial, string codArea, string telefono, string mail, string numAfiliadoOS)
        {
            //IdPersona = CSE_UserCache.IdPersona;
            Apellido = apellido;
            Nombre = nombre;
            Genero = genero;
            TipoDoc = tipoDoc;
            IdSinDniARG = idSinDniARG;
            DocDescripOtros = docDescripOtros;
            NumDoc = numDoc;
            LetraDoc = letraDoc;
            CUIL = cuil;
            FechaNac = fechaNac;
            LugNacimiento = lugNacimiento;
            IdNacionalidad = idNacionalidad;
            IdProvincia = idProvincia;
            IdPartido = idPartido;
            IdLocalidad = idLocalidad;
            EstadoCivil = estadoCivil;
            CantHijos = cantHijos;
            FamiliaresCargo = familiaresCargo;
            Grupo = grupo;
            IdInstitucion = idInstitucion;
            IdCarrera = idCarrera;
            DescTituloSec = descTituloSec;
            Escuela = escuela;
            Completo = completo;
            NoSecComp_NActa_AAdm = noSecComp_NActa_AAdm;
            Distrito = distrito;
            YearEgreso = yearEgreso;
            InstitucionEst = institucionEst;
            TipoTitulo = tipoTitulo;
            Grado = grado;
            Titulo = titulo;
            EgresoYear = egresoYear;
            Trabaja = trabaja;
            Actividad = actividad;
            Horario = horario;
            ObraSocial = obraSocial;
            TieneObraSocial = tieneObraSocial;
            CodArea = codArea;
            Telefono = telefono;
            Mail = mail;
            NumAfiliadoOS = numAfiliadoOS;
        }

        //Método para guardar la preinscripción (COMPROBAR ERROR) <<<<<<<<<<----->>>>>>>>>>>
        public int IdPersonaPreinscripcion()
        {
            cL_Usuario.ConsultarUsuarios();
            return cL_Usuario.IdPersona;

        }
        // Método para guardar la preinscripción
        public void GuardarPreinscripcion()
        {
            CD_DatosPreinscripciones datoAlumnoPre = new CD_DatosPreinscripciones
            {
                // Asignar los valores desde las propiedades de la clase
                IdPersona = CSE_UserCache.IdPersona,
                Apellido = this.Apellido,
                Nombre = this.Nombre,
                Genero = this.Genero,
                TipoDoc = this.TipoDoc,
                IdSinDniARG = this.IdSinDniARG,
                DocDescripOtros = this.DocDescripOtros,
                NumDoc = this.NumDoc,
                LetraDoc = this.LetraDoc,
                CUIL = this.CUIL,
                FechaNac = this.FechaNac,
                LugNacimiento = this.LugNacimiento,
                IdNacionalidad = this.IdNacionalidad,
                IdProvincia = this.IdProvincia,
                IdPartido = this.IdPartido,
                IdLocalidad = this.IdLocalidad,
                EstadoCivil = this.EstadoCivil,
                CantHijos = this.CantHijos,
                FamiliaresCargo = this.FamiliaresCargo,
                Grupo = this.Grupo,
                IdInstitucion = this.IdInstitucion,
                IdCarrera = this.IdCarrera,
                DescTituloSec = this.DescTituloSec,
                Escuela = this.Escuela,
                Completo = this.Completo,
                NoSecComp_NActa_AAdm = this.NoSecComp_NActa_AAdm,
                Distrito = this.Distrito,
                YearEgreso = this.YearEgreso,
                InstitucionEst = this.InstitucionEst,
                TipoTitulo = this.TipoTitulo,
                Grado = this.Grado,
                Titulo = this.Titulo,
                EgresoYear = this.EgresoYear,
                Trabaja = this.Trabaja,
                Actividad = this.Actividad,
                Horario = this.Horario,
                ObraSocial = this.ObraSocial,
                TieneObraSocial = this.TieneObraSocial,
                CodArea = this.CodArea,
                Telefono = this.Telefono,
                Mail = this.Mail,
                NumAfiliadoOS = this.NumAfiliadoOS

            };

            CD_AlmunoPreInscripcion cdAlumnoPreInscripcion = new CD_AlmunoPreInscripcion();
            cdAlumnoPreInscripcion.InsertarPreinscripciones(datoAlumnoPre);
        }
    }
}
