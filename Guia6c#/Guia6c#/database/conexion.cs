using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Windows.Forms;
/*
public class ConexionBD
{
    private MySqlConnection connection;
    private string connectionString;

    public ConexionBD()
    {
        // Configura la cadena de conexión
        connectionString = "Server=localhost;Database=biblioteca;User=root;Password=12345678;";
        connection = new MySqlConnection(connectionString);
    }

    public bool AbrirConexion()
    {
        try
        {
            dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Error al abrir la conexión a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public void CerrarConexion()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}
*/