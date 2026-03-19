using System;
using System.Linq;
using System.Security.Cryptography;

namespace CapaServicios
{
    /*
     CLASE PARA ARMAR CONTRASEÑAS O CODIGOS NUMERICOS ALEATORIOS DE LONGITUD VARIABLE
     */
    public static class CSR_Aleatorios
    {
        /*
        El siguiente metodo recibirá 3 parametros:
        El primero (booleano) = true si es alfanumerico / false si es solo numerico
        El segundo Parametro (entero) corresponde a la cantidad minima de digitos que devolvera el metodo de la clase
        El tercer parametro (eltero) es opcional, y se refiere a la cantidad de caracteres especiales que contendra el string devuelto
         */
        /*
        public static string Armar(bool EsCaracteres = true, int Cant = 6, int CantCaractEspeciales = 2)
        {
            string caracteres = "0123456789", resultado = "";
            if (!EsCaracteres)
            {
                char[] arrayCaracteres = new char[Cant];
                Random random = new Random();
                for (int i = 0; i < arrayCaracteres.Length; i++)
                {
                    arrayCaracteres[i] = caracteres[random.Next(caracteres.Length)];
                }
                resultado = new String(arrayCaracteres);
            }
            else
            {
                resultado = GeneratePassword(Cant, CantCaractEspeciales);
                //resultado = Membership.GeneratePassword(Cant, CantCaractEspeciales);
            }
            return resultado;
        }

        private static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters)
        {
            const string alphanumericCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string nonAlphanumericCharacters = "!@#$%^&*()_-+=[{]};:<>|./?";

            if (numberOfNonAlphanumericCharacters > length)
                throw new ArgumentException("numberOfNonAlphanumericCharacters cannot be greater than length");

            var passwordChars = new char[length];
            var random = new RNGCryptoServiceProvider();

            for (int i = 0; i < length - numberOfNonAlphanumericCharacters; i++)
            {
                passwordChars[i] = alphanumericCharacters[GetRandomInt(random, alphanumericCharacters.Length)];
            }

            for (int i = length - numberOfNonAlphanumericCharacters; i < length; i++)
            {
                passwordChars[i] = nonAlphanumericCharacters[GetRandomInt(random, nonAlphanumericCharacters.Length)];
            }

            return new string(passwordChars.OrderBy(c => GetRandomInt(random, length)).ToArray());
        }

        private static int GetRandomInt(RandomNumberGenerator random, int max)
        {
            var data = new byte[4];
            random.GetBytes(data);
            return BitConverter.ToInt32(data, 0) % max;
        }
    }
}
*/
        public static string Armar(bool EsCaracteres = true, int Cant = 10, int CantCaractEspeciales = 2)
        {
            string resultado = "";

            // Verificamos que el número de caracteres especiales no sea mayor que la longitud total
            if (CantCaractEspeciales > Cant)
                throw new ArgumentException("El número de caracteres especiales no puede ser mayor que la longitud total de la contraseña.");

            // Si se quiere una contraseña alfanumérica + caracteres especiales
            if (EsCaracteres)
            {
                // Generar la contraseña con la cantidad correcta de caracteres especiales
                resultado = GeneratePassword(Cant, CantCaractEspeciales);
            }
            else
            {
                // Si es solo numérica, solo generamos dígitos
                resultado = GenerateNumericPassword(Cant);
            }

            return resultado;
        }

        private static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters)
        {
            const string alphanumericCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string nonAlphanumericCharacters = "!@#$%^&*()_-+=[{]};:<>|./?";

            // Crear un arreglo de caracteres para la contraseña
            var passwordChars = new char[length];

            // Aseguramos que la cantidad de caracteres especiales no sea mayor que la longitud
            if (numberOfNonAlphanumericCharacters > length)
                throw new ArgumentException("numberOfNonAlphanumericCharacters cannot be greater than length");

            using (var random = new RNGCryptoServiceProvider())
            {
                // Llenamos los primeros caracteres con caracteres alfanuméricos
                for (int i = 0; i < length - numberOfNonAlphanumericCharacters; i++)
                {
                    passwordChars[i] = alphanumericCharacters[GetRandomInt(random, alphanumericCharacters.Length)];
                }

                // Llenamos los caracteres restantes con caracteres especiales
                for (int i = length - numberOfNonAlphanumericCharacters; i < length; i++)
                {
                    passwordChars[i] = nonAlphanumericCharacters[GetRandomInt(random, nonAlphanumericCharacters.Length)];
                }

                // Barajamos el arreglo para que los caracteres especiales no estén al final siempre
                return new string(passwordChars.OrderBy(c => GetRandomInt(random, length)).ToArray());
            }
        }

        private static string GenerateNumericPassword(int length)
        {
            const string numericCharacters = "0123456789";
            var passwordChars = new char[length];

            using (var random = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < length; i++)
                {
                    passwordChars[i] = numericCharacters[GetRandomInt(random, numericCharacters.Length)];
                }

                return new string(passwordChars);
            }
        }

        private static int GetRandomInt(RandomNumberGenerator random, int max)
        {
            var data = new byte[4];
            random.GetBytes(data);
            int randomValue = BitConverter.ToInt32(data, 0) & 0x7FFFFFFF; // Asegurarse de que sea positivo
            return randomValue % max;
        }
    }
}
