using System.Linq;
//using System.Windows.Forms;

namespace CapaLogica
{
    public class CL_IngresoDatos
    {
        /*public static bool ValidarUsuario(string usuario)
        {
            if (usuario.Length >= 5 && usuario.Length <= 20)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarPassword(string password)
        {
            if (password.Length >= 8 && password.Length <= 20)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEmail(string email)
        {
            if (email.Length >= 5 && email.Length <= 50)
            {
                return true;
            }
            return false;
        }*/

        public string FiltrarTextoYConvertirAMayusculas(string texto)
        {
            // Obtenemos solo las letras del texto, descartando cualquier número o símbolo
            string soloTexto = new string(texto.Where(c => char.IsLetter(c)).ToArray());
            // Convertimos el texto a mayúsculas y lo devolvemos
            return soloTexto.ToUpper();
        }

        public string FiltrarSoloNumeros(string texto)
        {
            string soloNumeros = new string(texto.Where(c => char.IsDigit(c)).ToArray());
            return soloNumeros;
        }

        public string TextoMayusculas(string texto)
        {
            string soloTexto = texto.ToUpper();
            return soloTexto;
        }

        public string TextoNumerosMayusculas(string texto)
        {
            string soloTextoYNumeros = new string(texto.Where(c => char.IsLetterOrDigit(c)).ToArray());
            return soloTextoYNumeros.ToUpper();
        }
    }
}
