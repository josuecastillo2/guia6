using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Guia6c_
{
    public partial class Autenticacion : Form
    {
        /*
        private ConexionBD conexion;
        */
        public Autenticacion()
        {
            InitializeComponent();
        }
        /*
        private bool VerificarCredenciales(string usuario, string contraseña)
        {
            /*
            using (MySqlConnection dbConnection = conexion.AbrirConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @Usuario AND Clave = @Clave";

                using (MySqlCommand cmd = new MySqlCommand(query, dbConnection))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Clave", contraseña);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        */
        private void Autenticacion_Load(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos MySQL
            string cadenaConexion = "Server=localhost;Database=bd_login;User=root;Password=12345678;";

            using (MySqlConnection dbConnection = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    dbConnection.Open();
                    MessageBox.Show("Conexión a la base de datos exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Puedes continuar con el proceso de autenticación aquí
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Puedes tomar acciones adicionales, como cerrar la aplicación o inhabilitar la autenticación, según tus necesidades.
                }
            }
            
        }

        // Resto de tu código para el manejo de la autenticación
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btnAaceptar_Click(object sender, EventArgs e)
        {
            /*
            {
                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;

                if (VerificarCredenciales(usuario, contraseña))
                {
                    // Las credenciales son correctas, abre el formulario principal
                    frmpadre formularioPadre = new frmpadre();
                    formularioPadre.Show();

                    // Cierra el formulario de autenticación
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
                }*/
            }

        }
    
    }

