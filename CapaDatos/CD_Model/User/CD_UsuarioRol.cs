using System;

namespace CapaDatos.CD_Model.User
{
    public class CD_UsuarioRol
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public DateTime AltaDay { get; set; }
        public DateTime ModDay { get; set; }
        public DateTime BajaProgramDay { get; set; }
    }
}
