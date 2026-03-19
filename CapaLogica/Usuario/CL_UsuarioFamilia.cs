using CapaDatos;
using System.Collections.Generic;


namespace CapaLogica
{
    public class CL_UsuarioFamilia
    {
        public string Fdescripcion { get; set; }

        public static List<CL_UsuarioFamilia> ConsultarFamilia(string usuario)
        {
            CD_UsuarioFamilia cdUsuarioFamilia = new CD_UsuarioFamilia();
            List<CD_DatosUsuarioFamilia> datosFamilia = cdUsuarioFamilia.ConsultarFamilia(usuario); // Fixed method name

            List<CL_UsuarioFamilia> listaFamilia = new List<CL_UsuarioFamilia>();
            foreach (var datos in datosFamilia)
            {
                CL_UsuarioFamilia usuarioFamilia = new CL_UsuarioFamilia
                {
                    Fdescripcion = datos.Fdescripcion
                };
                listaFamilia.Add(usuarioFamilia);
            }
            return listaFamilia;
        }
    }
}

/*public class CL_UsuarioFamilia
{
    public string Fdescripcion { get; set; }

    CD_UsuarioFamilia cd_UsuarioFamilia = new CD_UsuarioFamilia();

    public List<CL_UsuarioFamilia> ConsultarFamilia(string usuario)
    {
        DataTable dtFamilia = cd_UsuarioFamilia.ConsultarFamilia(usuario);
        List<CL_UsuarioFamilia> listaFamilia = new List<CL_UsuarioFamilia>();

        foreach (DataRow row in dtFamilia.Rows)
        {
            listaFamilia.Add(new CL_UsuarioFamilia
            {
                Fdescripcion = row["Fdescripcion"].ToString() // Solo necesitas este campo
            });
        }

        return listaFamilia;
    }
}*/
/*namespace CapaLogica
    {
    public class CL_UsuarioFamilia

    {
        public string Nombre { get; set; }

        private CD_UsuarioPermiso cdFamilia = new CD_UsuarioPermiso();
        private CD_DatosUsuarioPermisos cdDatosUsuarioPermisos = new CD_DatosUsuarioPermisos();

        //private string usuario;

        private string usuario = CSE_UserCache.usuario; // Cambiado de 'username' a 'usuario'

        public List<CL_UsuarioFamilia> ConsultarFamilia(string usuario)
        {
            DataTable dtFamilia = cdFamilia.ConsultarFamilia(usuario);
            List<CL_UsuarioFamilia> listaFamilia = new List<CL_UsuarioFamilia>();

            foreach (DataRow row in dtFamilia.Rows)
            {
                listaFamilia.Add(new CL_UsuarioFamilia
                {
                    Nombre = row["Fdescriocion"].ToString() // Asegúrate de que el nombre de la columna sea correcto
                });
            }

            return listaFamilia;
        }
    }
}
*/