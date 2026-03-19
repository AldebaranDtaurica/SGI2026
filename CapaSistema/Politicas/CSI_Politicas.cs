using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaSistema
{
    public class CSI_Politicas
    {
        public CD_PoliticasPass datosPoliticas;

        public CSI_Politicas()
        {
            datosPoliticas = new CD_PoliticasPass();
        }

        public void GuardarConfiguracion(List<Tuple<int, bool>> configuraciones)
        {
            // Pasar la lista de configuraciones a la capa de datos
            datosPoliticas.ActualizarConfiguraciones(configuraciones);
        }

        public DataTable ObtenerConfiguraciones()
        {
            return datosPoliticas.ConsultarConfiguraciones();

        }


        public DataTable CacheConfiguraciones()
        {
            // Llamar al método de la capa de datos que devuelve las configuraciones
            DataTable datosPolitic = datosPoliticas.ConsultarConfiguraciones();
            // Asignar el valor de "Activo" de acuerdo al IdPol correspondiente a cada propiedad
            CSI_ConfiguracionCache.caracteres = ObtenerActivoPorIdPol(datosPolitic, 1);
            CSI_ConfiguracionCache.mayusculas = ObtenerActivoPorIdPol(datosPolitic, 2);
            CSI_ConfiguracionCache.minusculas = ObtenerActivoPorIdPol(datosPolitic, 3);
            CSI_ConfiguracionCache.especiales = ObtenerActivoPorIdPol(datosPolitic, 4);
            CSI_ConfiguracionCache.passAnteriores = ObtenerActivoPorIdPol(datosPolitic, 5);
            CSI_ConfiguracionCache.noDatosPersonales = ObtenerActivoPorIdPol(datosPolitic, 6);
            CSI_ConfiguracionCache.numeros = ObtenerActivoPorIdPol(datosPolitic, 7);
            CSI_ConfiguracionCache.intentosfallidos = ObtenerActivoPorIdPol(datosPolitic, 8);
            CSI_ConfiguracionCache.diasDesbloqueo = ObtenerActivoPorIdPol(datosPolitic, 9);
            // Retornar el DataTable con los resultados
            return datosPolitic;
        }
        private bool ObtenerActivoPorIdPol(DataTable datosPolitic, int idPol)
        {
            // Buscar la fila donde IdPol corresponde al valor que buscamos
            DataRow[] filas = datosPolitic.Select($"IdPol = {idPol}");

            // Verificar si se encontró la fila
            if (filas.Length > 0)
            {
                // Obtener el valor de la columna "Activo" y convertirlo a booleano
                return Convert.ToBoolean(filas[0]["Activo"]);
            }
            return false;
        }
    }
}
