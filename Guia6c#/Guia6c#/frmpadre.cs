using Guia6c_.fromulario;
using System;
using System.Windows.Forms;

namespace Guia6c_
{
    public partial class frmpadre : Form
    {
        public frmpadre()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmpadre_Load(object sender, EventArgs e)
        {
          /*  //Mostrar el formulario de autenticación
            Autenticacion loginForm = new Autenticacion();
            DialogResult result = loginForm.ShowDialog();

            // Verificar el resultado del formulario de autenticación
            if (result == DialogResult.OK)
            {
                // Las credenciales son válidas, continuar con la aplicación
            }
            else
            {
                // Las credenciales no son válidas o se cerró el formulario de autenticación, puedes manejarlo aquí
                MessageBox.Show("La autenticación falló o se cerró el formulario de autenticación.");
                this.Close(); // Cerrar la aplicación o realizar otra acción según tus necesidades*/
            }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Factura  FACTURA=new Factura();
            FACTURA.Show();   

        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambiar_Contraseña cambiar= new Cambiar_Contraseña();
            cambiar.Show(); 
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LayoutMdi(MdiLayout.TileVertical);

        }
    }


    }
