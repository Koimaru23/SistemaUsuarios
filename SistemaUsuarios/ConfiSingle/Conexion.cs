using System.Data.SqlClient;

namespace SistemaUsuarios.Config
{
    public class Conexion
    {
        private static Conexion _instancia = null;
        //Conexion con la basse de datos
        private string cadena = @"Data Source=.;Initial Catalog=SistemaUsuarios;User ID=sa;Password=1234;TrustServerCertificate=True";

        private Conexion() { } //Constructor para el Singleton

        public static Conexion GetInstancia()
        {
            if (_instancia == null) _instancia = new Conexion();
            return _instancia;
        }

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}