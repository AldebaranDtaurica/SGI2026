using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class CD_Conexion
    {
        private readonly string connectionstring;
        private readonly string connectionStringMas;

        public CD_Conexion()
        {
            
		// Usamos el nombre del servidor GANDALF\SQLEXPRESS
                connectionstring = "Server=GANDALF\\SQLEXPRESS;Database=SGInst_172;Integrated Security=True;TrustServerCertificate=True";
            
		// conexión a master con el servidor correcto
          	 connectionStringMas = "Server=GANDALF\\SQLEXPRESS;Database=master;Integrated Security=True";
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
