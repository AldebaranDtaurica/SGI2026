using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class CL_ValidacionPreinscripciones
    {

        private readonly CD_ValidacionPreinscripciones cd_validacionPreinscripciones = new CD_ValidacionPreinscripciones();

        public DataTable ObtenerValidacionPreinscripciones()
        {
            return cd_validacionPreinscripciones.SelectValidaPersEstudios();
        }
    }
}
