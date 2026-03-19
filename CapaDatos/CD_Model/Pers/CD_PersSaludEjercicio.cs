namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersSaludEjercicio
    {
        //public int IdPersSaludEjercicio { get; set; }
        //public int IdPersona { get; set; }
        //public bool Activo { get; set; }
        public bool Desmayo { get; set; }
        public bool MayorCansancioQ { get; set; }
        public bool DolorPecho { get; set; }
        public bool Palpitaciones { get; set; }
        public bool Mareos { get; set; }
        public bool DifRespirarActFisic { get; set; }
        //public DateTime Fecha { get; set; }
        public string Usuario { get; set; }



        public void Guardar(CD_PersSaludEjercicio cdPersSaludEjercicio)
        {
            // Implementa la lógica para guardar los datos en la base de datos
            // Ejemplo:
            // string query = "INSERT INTO PersSaludEjercicio (Id, Nombre, Edad, TipoEjercicio) VALUES (@Id, @Nombre, @Edad, @TipoEjercicio)";
            // Usa ADO.NET o cualquier otra tecnología para ejecutar la consulta
        }
    }


}
