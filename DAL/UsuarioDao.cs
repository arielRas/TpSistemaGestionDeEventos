using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDao
    {
        public bool ValidarCredenciales(string email, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbGestionEventos"].ConnectionString;

            string sqlQuery = "SELECT COUNT(*) FROM USUARIOS WHERE ID_TIPO_USUARIO = 1 AND EMAIL = @email AND [PASSWORD] = @password";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (connection)
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        command.Parameters.AddWithValue("@password", password);

                        if (Convert.ToInt32(command.ExecuteScalar()) == 1)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void InstanciarUsuario(string email) //REVISAR NOMBRE
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbGestionEventos"].ConnectionString;

            string sqlQuery = "SELECT ID_USUARIO, NOMBRE, APELLIDO, DNI, EMAIL FROM USUARIOS WHERE EMAIL = @email";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (connection)
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UsuarioEntity.GetInstance(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt64(3), reader.GetString(4));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
