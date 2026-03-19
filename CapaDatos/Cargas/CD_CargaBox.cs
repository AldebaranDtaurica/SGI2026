using System.Data;

namespace CapaDatos
{
    public class CD_CargaBox : CD_EjecutarSP
    {
        private readonly CD_EjecutarSP ejecutarSP = new CD_EjecutarSP();

        public DataTable BoxCategoriasAdj()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxCategoriasAdj");
        }
        public DataTable BoxEstCivil()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxEstCivil");
        }
        public DataTable BoxGenero()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxGenero");
        }
        public DataTable BoxIdioma()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxIdioma");
        }
        public DataTable BoxIngresoTitulo()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxIngresoTitulo");
        }
        public DataTable BoxLocalidad()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxLocalidad");
        }
        public DataTable BoxNacionalidad()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxNacionalidad");
        }
        public DataTable BoxParamInstitucional()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxParamInstitucional");
        }
        public DataTable BoxPartido()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxPartido");
        }
        public DataTable BoxPersGrupo()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxPersGrupo");
        }
        public DataTable BoxProvincia()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxProvincia");
        }
        public DataTable BoxTipoContacto()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxTipoContacto");
        }
        public DataTable BoxTipoDoc()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxTipoDoc");
        }
        public DataTable BoxFamilia()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxFamilia");
        }
        public DataTable BoxRol()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxRol");
        }
        public DataTable BoxCarreras()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxCarreras");
        }
        public DataTable BoxActividades()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxActividades");
        }
        public DataTable BoxObraSocial()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxObraSocial");
        }
        public DataTable BoxInstitucion()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxInstitucion");
        }
        public DataTable BoxSinDniArg()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxSinDniArg");
        }
        public DataTable BoxTituloGrado()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxTituloGrado");
        }
        public DataTable BoxDivision()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxDivision");
        }
        public DataTable BoxPersona()
        {
            return ejecutarSP.EjecutarConsultasSinParam("sp_select_BoxPersona");
        }
    }
}
