using System;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersSaludAlergias
    {
        public int IdPersSaludAlergias { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool Medicamentos { get; set; }
        public bool InternacMedicamentos { get; set; }
        public bool PicInsect { get; set; }
        public bool InternacPicInsect { get; set; }
        public bool Vacunas { get; set; }
        public bool InternacVacunas { get; set; }
        public bool Estacionales { get; set; }
        public bool InternacEstacionales { get; set; }
        public bool Alimentos { get; set; }
        public bool InternacAlimentos { get; set; }
        public bool Otras { get; set; }
        public bool InternacOtras { get; set; }
        public string DescripOtras { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }


        public void Guardar(CD_PersSaludAlergias cdPersSaludAlergias)
        {
            // Implementa la lógica para guardar los datos en la base de datos
            // Ejemplo:
            // string query = "INSERT INTO PersSaludEjercicio (Id, Nombre, Edad, TipoEjercicio) VALUES (@Id, @Nombre, @Edad, @TipoEjercicio)";
            // Usa ADO.NET o cualquier otra tecnología para ejecutar la consulta
        }
    }
}
