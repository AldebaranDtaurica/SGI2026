using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class CL_AbmPerfiles
    {
        public CD_AbmPerfiles datos;

        public CL_AbmPerfiles()
        {
            datos = new CD_AbmPerfiles();
        }

        // Método para Consultar Perfiles (no requiere cambio, ya que no depende de idUser)
        public DataTable ConsultarPerfiles(bool conBajas)
        {
            return datos.ConsultarPerfiles(conBajas);
        }

        // Método para Consultar la Lista de Permisos (no requiere cambio)
        public DataTable ConsultarPermisosLst()
        {
            return datos.ConsultarPermisosLst();
        }

        // Método para Alta de Perfil (requiere pasar idUser)
        public void AltaPerfil(string nombrePerfil, string descripcion, int[] permisos, int idUser)
        {
            // Convertimos el arreglo de permisos a una lista
            List<int> listaPermisos = new List<int>(permisos);

            // Llamamos al método de la capa de datos, pasando idUser
            datos.AltaPerfil(nombrePerfil, descripcion, listaPermisos, idUser);
        }

        // Método para Baja de Perfil (requiere pasar idUser)
        public void BajaPerfil(int idPerfil, int idUser)
        {
            // Llamamos al método de la capa de datos, pasando idUser
            datos.BajaPerfil(idPerfil, idUser);
        }

        // Método para Asignar Permisos (requiere pasar idUser)
        /*public void AsignarPermisos(int idPerfil, List<int> permisos, int idUser)
        {
            // Llamamos al método de la capa de datos, pasando idUser
            datos.AsignarPermisos(idPerfil, permisos, idUser);
        }

        // Método para Desasignar Permisos (requiere pasar idUser)
        public void DesasignarPermisos(int idPerfil, List<int> permisos, int idUser)
        {
            // Llamamos al método de la capa de datos, pasando idUser
            datos.DesasignarPermisos(idPerfil, permisos, idUser);
        }*/

        public DataTable ConsultarFamiliaPermisos(string Familia)
        {
            return datos.ConsultarFamiliaPermisos(Familia);
        }


    }
}




/*int idUser = 1; // Este ID proviene del usuario logueado en el sistema

// Alta de perfil
int[] permisos = { 1, 2, 3 };  // Ejemplo de permisos
abmPerfiles.AltaPerfil("Administrador", "Perfil con acceso total", permisos, idUser);

// Asignar permisos
abmPerfiles.AsignarPermisos(perfilId, permisos, idUser);

// Baja de perfil
abmPerfiles.BajaPerfil(perfilId, idUser);*/

