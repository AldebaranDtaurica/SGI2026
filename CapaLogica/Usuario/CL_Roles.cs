using CapaDatos.Usuario;
using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace CapaLogica.Usuario
{
    public class CL_Roles
    {
        /*private string Rol { get; set; }
        private string Familia { get; set; }
        private int IdRol { get; set; }
        private DateTime Baja { get; set; }
        private int DiasCambioClave { get; set; }
        private int IdPersona { get; set; }
        private int RowIndex { get; set; }
        private int IdUser { get; set; }
        */
        CD_Roles cdRoles = new CD_Roles();

        public CL_Roles() { }

        public DataTable dtRol { get; set; }

        public DataTable ConsultarRol(int IdPersona)
        {
            dtRol = cdRoles.ConsultarRol(IdPersona);
            var filasFiltradas = dtRol.AsEnumerable();
            if (filasFiltradas.Any())
            {
                return dtRol = filasFiltradas.CopyToDataTable();
            }
            else
            {
                return dtRol.Clone();

            }
        }

        public DataTable ConsultarRolActivo(int IdPersona)
        {
            DataTable dtActivo = dtRol;
            var filasFiltradas = dtActivo.AsEnumerable().Where(row => row.Field<bool>("Estado") == true);
            if (filasFiltradas.Any())
            {
                return dtActivo = filasFiltradas.CopyToDataTable();
            }
            else
            {
                return dtActivo = dtActivo.Clone();
            }
        }

        public DataTable ConsultarRolInactivo(int IdPersona)
        {
            DataTable dtInactivo = dtRol;
            var filasFiltradas = dtInactivo.AsEnumerable().Where(row => row.IsNull("IdPersona") && row.Field<bool>("Estado") == false);
            if (filasFiltradas.Any())
            {
                return dtInactivo = filasFiltradas.CopyToDataTable();
            }
            else
            {
                return dtInactivo = dtInactivo.Clone();
            }
        }

        public bool GuardarConfiguracionRoles(DataTable dtRolesActualizados, int idUsuario)
        {
            try
            {

                if (dtRolesActualizados.Rows.Count == 0)
                {
                    throw new Exception("Debe tener al menos un rol");
                }
                return cdRoles.ActualizarRolesUsuario(dtRolesActualizados, idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Lógica al guardar roles: " + ex.Message);
            }
        }

        public bool GuardarAsignacionesPP(DataTable dtAsignacionesPP, int idPersona, string famlia, bool condicion)
        {
            try
            {

                if (dtAsignacionesPP.Rows.Count == 0)
                {
                    throw new Exception("Debe tener al menos un rol");
                }
                return cdRoles.GuardarAsignacionesPP(dtAsignacionesPP, idPersona, famlia, condicion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Lógica al guardar roles: " + ex.Message);
            }
        }


    }
}
