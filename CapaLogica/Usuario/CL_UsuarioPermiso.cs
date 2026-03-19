using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class CL_UsuarioPermiso
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public int IdRol { get; set; }
        public DateTime BajaProgramDay { get; set; }
        public string Rdescripcion { get; set; }

        //public int IdFamilia { get; set; }
        //public string Fdescripcion { get; set; }

        private readonly CD_UsuarioPermiso cD_UsuarioPermiso = new CD_UsuarioPermiso();


        private List<string> listaRdescripcion;

        public void CargarCache(DataTable tablaDatos)
        {
            listaRdescripcion = new List<string>();

            foreach (DataRow fila in tablaDatos.Rows)
            {
                string rdescripcion = fila["Rdescripcion"].ToString();
                listaRdescripcion.Add(rdescripcion);
            }

        }

        public DataTable ObtenerPermisos(CD_UsuarioPermiso cD_UsuarioPermiso)
        {
            if (string.IsNullOrEmpty(CSE_UserCache.usuario))
            {
                throw new Exception("El usuario no está definido.");
            }

            _ = new CD_DatosUsuarioPermisos()
            {
                IdUser = CSE_PermisoCache.IdUser,
                Username = CSE_PermisoCache.Username,
                IdRol = CSE_PermisoCache.IdRol,
                BajaProgramDay = CSE_PermisoCache.BajaProgramDay,
                Rdescripcion = CSE_PermisoCache.Rdescripcion,
                //IdFamilia = CSE_PermisoCache.IdFamilia,
                //Fdescripcion = CSE_PermisoCache.Fdescripcion
            };

            DataTable tablaDatos = cD_UsuarioPermiso.ConsultarPermisos(CSE_UserCache.usuario);
            CargarCache(tablaDatos);
            return tablaDatos;
        }

        // Método para obtener la lista de Rdescripcion
        /*public List<string> ObtenerRdescripciones()
        {
            return listaRdescripcion;
        }*/

        public DataTable ObtenerPermisos()
        {
            return ObtenerPermisos(cD_UsuarioPermiso);
        }



        /*public void InsertarPermisos()
        {
            CD_DatosUsuarioPermisos usuarioPermiso = new CD_DatosUsuarioPermisos()
            {
                IdUser = this.IdUser,
                Username = this.Username,
                IdRol = this.IdRol,
                BajaProgramDay = this.BajaProgramDay,
                Rdescripcion = this.Rdescripcion,
                //IdFamilia = this.IdFamilia,
                //Fdescripcion = this.Fdescripcion
            };

            cD_UsuarioPermiso.InsertarPermisos(usuarioPermiso);
        }*/


    }
}

