using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class CL_CargaBox
    {
        CD_CargaBox cdCargaBox = new CD_CargaBox();

        public DataTable ClBoxCategoriasAdj()
        {
            return cdCargaBox.BoxCategoriasAdj();
        }
        public DataTable BoxEstCivil()
        {
            return cdCargaBox.BoxEstCivil();
        }
        public DataTable BoxGenero()
        {
            return cdCargaBox.BoxGenero();
        }
        public DataTable BoxIdioma()
        {
            return cdCargaBox.BoxIdioma();
        }
        public DataTable BoxIngresoTitulo()
        {
            return cdCargaBox.BoxIngresoTitulo();
        }
        public DataTable BoxLocalidad()
        {
            return cdCargaBox.BoxLocalidad();
        }
        public DataTable BoxNacionalidad()
        {
            return cdCargaBox.BoxNacionalidad();
        }
        public DataTable BoxParamInstitucional()
        {
            return cdCargaBox.BoxParamInstitucional();
        }
        public DataTable BoxPartido()
        {
            return cdCargaBox.BoxPartido();
        }
        public DataTable BoxPersGrupo()
        {
            return cdCargaBox.BoxPersGrupo();
        }
        public DataTable BoxProvincia()
        {
            return cdCargaBox.BoxProvincia();
        }
        public DataTable BoxTipoContacto()
        {
            return cdCargaBox.BoxTipoContacto();
        }
        public DataTable BoxTipoDoc()
        {
            return cdCargaBox.BoxTipoDoc();
        }
        public DataTable BoxFamilia()
        {
            return cdCargaBox.BoxFamilia();
        }
        public DataTable BoxRol()
        {
            return cdCargaBox.BoxRol();
        }
        public DataTable BoxCarreras()
        {
            return cdCargaBox.BoxCarreras();
        }
        public DataTable BoxActividades()
        {
            return cdCargaBox.BoxActividades();
        }
        public DataTable BoxObraSocial()
        {
            return cdCargaBox.BoxObraSocial();
        }
        public DataTable BoxInstitucion()
        {
            return cdCargaBox.BoxInstitucion();
        }
        public DataTable BoxSinDniArg()
        {
            return cdCargaBox.BoxSinDniArg();
        }
        public DataTable BoxTituloGrado()
        {
            return cdCargaBox.BoxTituloGrado();
        }
        public DataTable BoxDivision()
        {
            return cdCargaBox.BoxDivision();
        }
        public DataTable BoxPersona()
        {
            return cdCargaBox.BoxPersona();
        }
    }
}
/*public List<Grupo> ObtenerGrupos()
{
// Implementación del método para obtener los grupos
    return new List<Grupo>
{
    new Grupo { Id = 1, Nombre = "Grupo 1" },
    new Grupo { Id = 2, Nombre = "Grupo 2" }
};
}
}

public class Grupo
{
public int Id { get; set; }
public string Nombre { get; set; }
}*/

