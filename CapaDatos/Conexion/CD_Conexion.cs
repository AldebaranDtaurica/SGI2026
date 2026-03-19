using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class CD_Conexion
    {
        private readonly string connectionstring;
        private readonly string connectionStringMas;

        public CD_Conexion()
        {
            // Conexión a la base de datos SGInst
            connectionstring = "Server=localhost\\SQLEXPRESS01;Database=SGInst_172;Integrated Security=True";

            // Conexión a la base de datos master
            connectionStringMas = "Server=localhost\\SQLEXPRESS;Database=master;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }

        protected SqlConnection GetConnectionMas()
        {
            return new SqlConnection(connectionStringMas);
        }
    }
}
