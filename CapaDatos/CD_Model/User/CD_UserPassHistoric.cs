using System;

namespace CapaDatos.CD_Model.User
{
    public class CD_UserPassHistoric
    {
        public int IdPassHistoric { get; set; }
        public int IdUser { get; set; }
        public string Passkey { get; set; }
        public string DigitPass { get; set; }
        public DateTime AltaDay { get; set; }
        public DateTime BajaDay { get; set; }
    }
}
