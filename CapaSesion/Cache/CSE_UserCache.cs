using System;

namespace CapaSesion
{
    public static class CSE_UserCache
    {
        public static int IdUser { get; set; }
        public static int id { get; set; }
        public static string usuario { get; set; }
        public static string password { get; set; }
        public static string digito { get; set; }
        public static string email { get; set; }
        public static bool bloqueo { get; set; }
        public static int intentos { get; set; }
        public static DateTime baja { get; set; }
        public static bool nuevo { get; set; }
        public static bool recupero { get; set; }
        public static DateTime alta { get; set; }
        public static DateTime modificacion { get; set; }
        public static int IdPersona { get; set; }
        public static int cambiaCada { get; set; }
        //public static int idPerfil { get; set; }
        public static string Familia { get; set; }
        public static DateTime FechaActual { get; set; }


        public static void Clear()
        {
            Type tipo = typeof(CSE_UserCache);

            foreach (var propiedad in tipo.GetProperties())
            {
                if (propiedad.CanWrite && propiedad.GetSetMethod() != null)
                {
                    propiedad.SetValue(null, null);
                }
            }
        }
    }
}
