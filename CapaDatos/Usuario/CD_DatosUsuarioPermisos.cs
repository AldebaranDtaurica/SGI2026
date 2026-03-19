using System;

namespace CapaDatos
{
    public class CD_DatosUsuarioPermisos
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public int IdRol { get; set; }
        public DateTime BajaProgramDay { get; set; }
        public string Rdescripcion { get; set; }
        //public object IdFamilia { get; set; }
        //public object Fdescripcion { get; set; }
    }
}
