using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;


namespace VistaSGI.Lenguaje
{

    public static class CV_Lenguaje
    {
        public static void CambiarIdioma(Form formulario, string cultura)
        {
            // 1. Establecemos la cultura global
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);

            // 2. Creamos el ResourceManager (Asegúrate de poner: TuProyecto.Lenguaje)
            // El nombre debe ser: NombreDeTuProyecto + "." + NombreDelResx
            ResourceManager res = new ResourceManager(typeof(LenguajeEs));

            // 3. Traducimos el título del formulario
            string titulo = res.GetString(formulario.Name);
            if (!string.IsNullOrEmpty(titulo)) formulario.Text = titulo;

            // 4. Llamamos a la función recursiva para traducir todos los controles
            AplicarRecursos(formulario, res);
        }

        private static void AplicarRecursos(Control parent, ResourceManager res)
        {
            foreach (Control c in parent.Controls)
            {
                // Buscamos la traducción por el nombre del control
                string texto = res.GetString(c.Name);
                if (!string.IsNullOrEmpty(texto))
                {
                    c.Text = texto;
                }

                // Si el control tiene hijos (paneles, groupbox), entramos en ellos
                if (c.HasChildren)
                {
                    AplicarRecursos(c, res);
                }
            }
        }
        /*private void ActualizarTextos()
            {
                // Creamos un administrador de recursos para leer el archivo Lenguaje.resx
                ResourceManager res = new ResourceManager(typeof(Lenguaje));

                // Recorremos todos los controles del formulario
                foreach (Control c in this.Controls)
                {
                    // Buscamos si existe una traducción que se llame igual que el control
                    string traduccion = res.GetString(c.Name);

                    if (!string.IsNullOrEmpty(traduccion))
                    {
                        c.Text = traduccion;
                    }
                }
            }*/
    }
}