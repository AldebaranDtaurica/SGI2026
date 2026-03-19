using System;

namespace CapaSesion.CSE_Model.User
{
    public class CSE_Usuarios
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Passkey { get; set; }
        public string Email { get; set; }
        public DateTime AltaDay { get; set; }
        public DateTime ModDay { get; set; }
        public DateTime Bloqueoday { get; set; }
        public bool Bloqueo { get; set; }
        public int CantError { get; set; }
        public int IdFamilia { get; set; }
        public DateTime BajaDay { get; set; }
        public bool Primer { get; set; }
        public int CambiaCada { get; set; }
        public bool Recupero { get; set; }
        public int IdPersona { get; set; }
    }
}
