using System;
using System.Text.RegularExpressions;

namespace CapaServicios
{
    public static class CSR_ValidaMail
    {
        /* Metodo que valida el formato de los mails escribiendo en color rojo 
           mientras no se cumpla el formato correcto, cambiando a negro al momento 
           de cumplirse dicho formato. 
           Se llama al metodo desde la propiedad TextChanged del textBox correspondiente
           de la siguiente manera:

        if (!ValidaMail.Valid(txtCorreo.Text))
        {
            txtCorreo.ForeColor = Color.Red;
        }
        else
        {
            txtCorreo.ForeColor = Color.Black;
        }

        */

        public static bool Valid(string Correo)
        {
            string validacion;
            validacion = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            //@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(Correo, validacion))
            {
                if (Regex.Replace(Correo, validacion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
