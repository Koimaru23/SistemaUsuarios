using System.Data;
using System.Data.SqlClient;
using SistemaUsuarios.Config; //Conecta con singleton

namespace SistemaUsuarios.Data
{
    public class UsuarioDAO
    {
        //Atre los metodos 
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.GetInstancia().CrearConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM usuarios", con);
                da.Fill(tabla);
            }
            return tabla;
        }

        //Instar y guardar al usuario agregado
        public void Insertar(string nom, string ape, string user, string pass, string mail)
        {
            using (SqlConnection con = Conexion.GetInstancia().CrearConexion())
            {
                string sql = "INSERT INTO usuarios (nombre, apellido, username, password, email) VALUES (@n, @a, @u, @p, @e)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", nom);
                cmd.Parameters.AddWithValue("@a", ape);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@e", mail);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Metodo para eliminar 
        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.GetInstancia().CrearConexion())
            {
                string sql = "DELETE FROM usuarios WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para Editar
        public void Editar(int id, string nom, string ape, string user, string mail)
        {
            using (SqlConnection con = Conexion.GetInstancia().CrearConexion())
            {
                //El @ ayuda a saber que se esta cambiando
                string sql = "UPDATE usuarios SET nombre=@n, apellido=@a, username=@u, email=@e WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@n", nom);
                    cmd.Parameters.AddWithValue("@a", ape);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@e", mail);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}