using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace My_QuickCarry
{
    public partial class formLogin : Form
    {

        private Connection conexion = new Connection();

        string tipoUsuario;
        public formLogin()
        {
            InitializeComponent();
            conexion.ConnectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión a la base de datos: " + ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        private void FormLogin_Resize(object sender, EventArgs e)
        {
            int panelWidth = 300;  // Ancho deseado del panel
            int panelHeight = 200; // Altura deseada del panel
            int panelX = (this.Width - panelWidth) / 2;  // Posición X centrada
            int panelY = (this.Height - panelHeight) / 2; // Posición Y centrada

            panel1.Width = panelWidth;
            panel1.Height = panelHeight;
            panel1.Location = new Point(panelX, panelY);
        }


        private void etiUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {


            string nombreUsuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Realizar la verificación de las credenciales en la base de datos
            if (VerificarCredenciales(nombreUsuario, contrasena))
            {
                // Obtiene el tipo de usuario
              

                // Abre el formulario correspondiente según el tipo de usuario
                if (tipoUsuario == "admin")
                {
                    formAdmin formAdmin = new formAdmin();
                    formAdmin.Show();
                }
                else if (tipoUsuario == "camionero")
                {

                    formAdmin formAdmin = new formAdmin();
                    formAdmin.Show();

                }
                else if (tipoUsuario == "almacenero")
                {

                    formAdmin formAdmin = new formAdmin();
                    formAdmin.Show();

                }
                else if (tipoUsuario == "cliente")
                {

                    formAdmin formAdmin = new formAdmin();
                    formAdmin.Show();

                }

                // Cierra el formulario de inicio de sesión
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtelo de nuevo.");
            }






        }

        private bool VerificarCredenciales(string nombreUsuario, string contrasena)
        {
            Recordset rs = new Recordset();
            rs.Open("SELECT * FROM admin WHERE nombre_usuario = '" + nombreUsuario + "' AND contrasena = '" + contrasena + "'", conexion);

            if (!rs.EOF)
            {
                rs.Close();
                tipoUsuario = "admin";
                return true;

            }

            rs.Open("SELECT * FROM almacenero WHERE nombre_usuario = '" + nombreUsuario + "' AND contrasena = '" + contrasena + "'", conexion);

            if (!rs.EOF)
            {
                rs.Close();
                tipoUsuario = "almacenero";
                return true;

            }

            rs.Open("SELECT * FROM camionero WHERE nombre_usuario = '" + nombreUsuario + "' AND contrasena = '" + contrasena + "'", conexion);

            if (!rs.EOF)
            {
                rs.Close();
                tipoUsuario = "camionero";
                return true;

            }

            rs.Open("SELECT * FROM cliente WHERE nombre_usuario = '" + nombreUsuario + "' AND contrasena = '" + contrasena + "'", conexion);

            if (!rs.EOF)
            {
                rs.Close();
                tipoUsuario = "cliente";
                return true;

            }

            rs.Close();
            return false;
        }

       



    }
}