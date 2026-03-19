using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CapaServicios
{
    public static class CSR_Seguridad
    {
        // Encripta
        /*public static string Encriptar(this string _cadenaAencriptar)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            string result = Convert.ToBase64String(encryted);
            return result;
        }*/

        // Hashea
        public static string Hash(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            StringBuilder sb = new StringBuilder();
            byte[] stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static string GenerarStringAleatorio(int largo = 8)
        {
            int longitudCodigo = largo; // Longitud del código alfanumérico
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] codigoAlfanumerico = new char[longitudCodigo];

            for (int i = 0; i < longitudCodigo; i++)
            {
                int indiceCaracter = random.Next(caracteresPermitidos.Length);
                codigoAlfanumerico[i] = caracteresPermitidos[indiceCaracter];
            }

            string codigoGenerado = new string(codigoAlfanumerico);

            return codigoGenerado;
        }

        /*public static bool VerificarCuiCuil(string cuiCuil)
        {
            if (cuiCuil.Length != 11)
            {
                return false;
            }

            int[] coeficientes = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;

            for (int i = 0; i < coeficientes.Length; i++)
            {
                suma += int.Parse(cuiCuil[i].ToString()) * coeficientes[i];
            }

            int resto = suma % 11;
            int digitoVerificador = 11 - resto;

            if (resto == 0)
            {
                return int.Parse(cuiCuil[10].ToString()) == 0;
            }
            else if (resto == 1)
            {
                return int.Parse(cuiCuil[10].ToString()) == 1;
            }
            else
            {
                return int.Parse(cuiCuil[10].ToString()) == digitoVerificador;
            }
        }*/

        // Desencripta
        /*public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            string result = Encoding.Unicode.GetString(decryted);
            return result;
        }*/

        public static string ConvertStringToHex(string input)
        {
            string HexaInput = string.Join("", input.Select(c => ((int)c).ToString("X2")));
            return HexaInput;
        }

        public static int DigVerif(string Hexa) // Dígito verificador
        {
            int[] decimales = new int[Hexa.Length];
            int i = 0;

            // Convertir cada carácter hexadecimal a su valor decimal
            foreach (char caracter in Hexa)
            {
                decimales[i] = Convert.ToInt32(caracter.ToString(), 16); // Convertir hex a decimal
                i++;
            }

            // ALGORITMO DE LHUN
            // PASO 1: Invertir el arreglo de números
            Array.Reverse(decimales);

            // PASO 2: Multiplicar por 2 las posiciones pares comenzando por la 0
            int[] decimalesxDos = new int[decimales.Length];
            for (int x = 0; x < decimales.Length; x++)
            {
                if (x % 2 == 0) // Si la posición es par
                {
                    decimalesxDos[x] = decimales[x] * 2;

                    // Si el resultado es mayor o igual a 10, sumamos los dígitos (equivalente a restar 9)
                    if (decimalesxDos[x] >= 10)
                    {
                        decimalesxDos[x] -= 9; // Esto es lo mismo que sumar los dígitos de un número mayor a 9
                    }
                }
                else
                {
                    decimalesxDos[x] = decimales[x]; // Si no es par, se deja el valor original
                }
            }

            // PASO 3: Sumar todos los valores del arreglo
            int sumaTotal = decimalesxDos.Sum();

            // PASO 4: Calcular el módulo 10 de la suma total
            int digitoVerificador = sumaTotal % 10;

            // Si el módulo 10 no es 0, el dígito verificador es 10 - módulo
            if (digitoVerificador != 0)
            {
                digitoVerificador = 10 - digitoVerificador;
            }

            return digitoVerificador; // Retornar el dígito verificador calculado
        }

    }
}
