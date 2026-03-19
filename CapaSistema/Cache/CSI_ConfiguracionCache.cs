using System;

namespace CapaSistema
{
    public static class CSI_ConfiguracionCache
    {
        public static bool caracteres { get; set; }
        public static bool mayusculas { get; set; }
        public static bool minusculas { get; set; }
        public static bool especiales { get; set; }
        public static bool passAnteriores { get; set; }
        public static bool noDatosPersonales { get; set; }
        public static bool numeros { get; set; }
        public static bool intentosfallidos { get; set; }
        public static bool diasDesbloqueo { get; set; }
        public readonly static int Intentos = 3;
        public readonly static double LapsoBloqueo = 10;
        public readonly static DateTime FechaDefecto = Convert.ToDateTime("1900-01-01");
    }
}