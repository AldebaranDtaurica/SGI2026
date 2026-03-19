using System;

namespace CapaSesion
{
    public static class CSE_PermisoCache
    {
        public static int IdUser { get; set; }
        public static string Username { get; set; }
        public static int IdRol { get; set; }
        public static DateTime BajaProgramDay { get; set; }
        public static string Rdescripcion { get; set; }
        //public static int IdFamilia { get; set; }
        //public static string Fdescripcion { get; set; }


        public static void Clear()
        {
            Type tipo = typeof(CSE_PermisoCache);

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
