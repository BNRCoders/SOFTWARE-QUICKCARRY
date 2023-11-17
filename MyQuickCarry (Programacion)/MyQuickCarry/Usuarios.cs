using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using ADODB;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.ObjectModel;


namespace My_QuickCarry
{
    public partial class Usuarios : Form
    {

        
        private Recordset recordset = new Recordset();
        private DataTable dataTable;
        private Connection conexion = new Connection();
      

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            conexion.ConnectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";

           
            conexion.Open();
            string query = "SELECT id, nombre_usuario, contrasena FROM usuarios";

            recordset.Open(query, conexion, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

            // Crear un DataTable para almacenar los datos.
            DataTable dataTable = new DataTable();

            // Agregar columnas al DataTable.
            for (int i = 0; i < recordset.Fields.Count; i++)
            {
                dataTable.Columns.Add(recordset.Fields[i].Name);
            }

            // Llenar el DataTable con los datos del Recordset.
            while (!recordset.EOF)
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < recordset.Fields.Count; i++)
                {
                    row[i] = recordset.Fields[i].Value;
                }
                dataTable.Rows.Add(row);
                recordset.MoveNext();
            }

            // Asignar el DataTable como origen de datos para el DataGridView.
            dataGridView1.DataSource = dataTable;

            // Cerrar la conexión y el Recordset.
            recordset.Close();
            conexion.Close();

            // Refrescar y actualizar el DataGridView.
            dataGridView1.Refresh();





            string[] palabras = { "admin", "almacenero", "camionero", "cliente"};

            // Asigna el array al ComboBox
            tipoUsuario.Items.AddRange(palabras);

            // Selecciona el primer ítem por defecto
            tipoUsuario.SelectedIndex = 0;



        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        string contraseña;
        string usuario;
        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string nombreUsuario = dataGridView1.Rows[rowIndex].Cells["nombre_usuario"].Value.ToString();
                string contrasena = dataGridView1.Rows[rowIndex].Cells["contrasena"].Value.ToString();


                // Actualiza los TextBox con los valores de la fila seleccionada
                txtUser.Text = nombreUsuario;
                txtPassword.Text = contrasena;
            }
            else
            {
                // Maneja el caso en el que no se ha seleccionado ninguna fila
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);
                string nuevoUsuario = txtUser.Text;
                string nuevaContrasena = txtPassword.Text;

                try
                {
                    string connectionString = "DSN=awdadw;Uid=admin;Pwd=admin;";

                    Connection connection = new Connection();
                    connection.Open(connectionString);

                    string updateQuery = $"UPDATE Usuarios SET nombre_usuario = '{nuevoUsuario}', contrasena = '{nuevaContrasena}' WHERE ID = {id}";

                    Command command = new Command();
                    command.ActiveConnection = connection;
                    command.CommandText = updateQuery;
                    command.Execute(out var _, 0); // La función Execute no devuelve un valor útil


                    string query = "SELECT id, nombre_usuario, contrasena FROM usuarios";

                    recordset.Open(query, connection, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

                    // Crear un DataTable para almacenar los datos.
                    DataTable dataTable = new DataTable();

                    // Agregar columnas al DataTable.
                    for (int i = 0; i < recordset.Fields.Count; i++)
                    {
                        dataTable.Columns.Add(recordset.Fields[i].Name);
                    }

                    // Llenar el DataTable con los datos del Recordset.
                    while (!recordset.EOF)
                    {
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < recordset.Fields.Count; i++)
                        {
                            row[i] = recordset.Fields[i].Value;
                        }
                        dataTable.Rows.Add(row);
                        recordset.MoveNext();
                    }

                    // Asignar el DataTable como origen de datos para el DataGridView.
                    dataGridView1.DataSource = dataTable;

                    // Cerrar la conexión y el Recordset.
                    recordset.Close();


                    connection.Close();

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // Manejar el error apropiadamente, por ejemplo, mostrar un mensaje de error al usuario
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            string usuario = txtUserCrear.Text;
            string contraseña = txtPasswordCrear.Text;
            string connectionString = "DSN=awdadw;Uid=admin;Pwd=admin;";

            Connection connection = new Connection();
            connection.Open(connectionString);

            string insertQuery = $"INSERT INTO Usuarios(nombre_usuario, contrasena) VALUES('{usuario}', '{contraseña}')";

            Command command = new Command();
            command.ActiveConnection = connection;
            command.CommandText = insertQuery;
            command.Execute(out var _, 0); // La función Execute no devuelve un valor útil

            string query = "SELECT id, nombre_usuario, contrasena FROM usuarios";

            recordset.Open(query, connection, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

            // Crear un DataTable para almacenar los datos.
            DataTable dataTable = new DataTable();

            // Agregar columnas al DataTable.
            for (int i = 0; i < recordset.Fields.Count; i++)
            {
                dataTable.Columns.Add(recordset.Fields[i].Name);
            }

            // Llenar el DataTable con los datos del Recordset.
            while (!recordset.EOF)
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < recordset.Fields.Count; i++)
                {
                    row[i] = recordset.Fields[i].Value;
                }
                dataTable.Rows.Add(row);
                recordset.MoveNext();
            }

            // Asignar el DataTable como origen de datos para el DataGridView.
            dataGridView1.DataSource = dataTable;

            // Cerrar la conexión y el Recordset.
            recordset.Close();


            connection.Close();

            dataGridView1.Refresh();
        }

        private void txtPasswordCrear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);


                try
                {
                    string connectionString = "DSN=awdadw;Uid=admin;Pwd=admin;";

                    Connection connection = new Connection();
                    connection.Open(connectionString);

                    string deleteQuery = $"DELETE FROM Usuarios WHERE ID = '{id}'";

                    Command command = new Command();
                    command.ActiveConnection = connection;
                    command.CommandText = deleteQuery;
                    command.Execute(out var _, 0); // La función Execute no devuelve un valor útil


                    string query = "SELECT id, nombre_usuario, contrasena FROM usuarios";

                    recordset.Open(query, connection, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

                    // Crear un DataTable para almacenar los datos.
                    DataTable dataTable = new DataTable();

                    // Agregar columnas al DataTable.
                    for (int i = 0; i < recordset.Fields.Count; i++)
                    {
                        dataTable.Columns.Add(recordset.Fields[i].Name);
                    }

                    // Llenar el DataTable con los datos del Recordset.
                    while (!recordset.EOF)
                    {
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < recordset.Fields.Count; i++)
                        {
                            row[i] = recordset.Fields[i].Value;
                        }
                        dataTable.Rows.Add(row);
                        recordset.MoveNext();
                    }

                    // Asignar el DataTable como origen de datos para el DataGridView.
                    dataGridView1.DataSource = dataTable;

                    // Cerrar la conexión y el Recordset.
                    recordset.Close();


                    connection.Close();

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // Manejar el error apropiadamente, por ejemplo, mostrar un mensaje de error al usuario
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtUserCrear_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUserCrear.Text;
            string contraseña = txtPasswordCrear.Text;
            string tusuario = tipoUsuario.Text;
            int cedula = int.Parse(txtCedula.Text); 
            
            conexion.Open();

            // Paso 1: Agregar el usuario a la tabla Usuarios
            string insertQuery1 = $"INSERT INTO usuarios (nombre_usuario, contrasena) VALUES ('{usuario}', '{contraseña}')";
            conexion.Execute(insertQuery1, out object _, 0);

            if (tusuario == "cliente")
            {
                // Paso 3: Agregar el usuario a la tabla admin utilizando el último ID
                string insertQuery2 = $"INSERT INTO cliente(id, nombre_usuario, contrasena, cedula) VALUES ((SELECT LAST_INSERT_ID()) , '{usuario}', '{contraseña}', {cedula})";
                conexion.Execute(insertQuery2, out object _, 0);
            }
        
      

            // Paso 4: Obtener todos los usuarios
            string query = "SELECT id, nombre_usuario, contrasena FROM Usuarios";
            recordset.Open(query, conexion, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

            // Crear un DataTable para almacenar los datos.
            DataTable dataTable = new DataTable();

            // Agregar columnas al DataTable.
            for (int i = 0; i < recordset.Fields.Count; i++)
            {
                dataTable.Columns.Add(recordset.Fields[i].Name);
            }

            // Llenar el DataTable con los datos del Recordset.
            while (!recordset.EOF)
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < recordset.Fields.Count; i++)
                {
                    row[i] = recordset.Fields[i].Value;
                }
                dataTable.Rows.Add(row);
                recordset.MoveNext();
            }

            // Asignar el DataTable como origen de datos para el DataGridView.
            dataGridView1.DataSource = dataTable;

            // Cerrar la conexión y el Recordset.
            recordset.Close();
            conexion.Close();

            dataGridView1.Refresh();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value);


                try
                {
                    string connectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";

                    Connection connection = new Connection();
                    connection.Open(connectionString);





                    string[] tablas = { "admin", "almacenero", "camionero", "cliente" };

                    foreach (string tabla in tablas)
                    {
                        // Realiza la búsqueda y eliminación en cada tabla
                        string consultaBorrado = $"DELETE FROM {tabla} WHERE id = {id}";
                        conexion.Execute(consultaBorrado, out object _, -1);
                    }

                    string deleteQuery = $"DELETE FROM Usuarios WHERE id = '{id}'";

                    

                    Command command = new Command();
                    command.ActiveConnection = connection;
                    command.CommandText = deleteQuery;
                    command.Execute(out var _, 0); // La función Execute no devuelve un valor útil


                    string query = "SELECT id, nombre_usuario, contrasena FROM usuarios";

                    recordset.Open(query, connection, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

                    // Crear un DataTable para almacenar los datos.
                    DataTable dataTable = new DataTable();

                    // Agregar columnas al DataTable.
                    for (int i = 0; i < recordset.Fields.Count; i++)
                    {
                        dataTable.Columns.Add(recordset.Fields[i].Name);
                    }

                    // Llenar el DataTable con los datos del Recordset.
                    while (!recordset.EOF)
                    {
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < recordset.Fields.Count; i++)
                        {
                            row[i] = recordset.Fields[i].Value;
                        }
                        dataTable.Rows.Add(row);
                        recordset.MoveNext();
                    }

                    // Asignar el DataTable como origen de datos para el DataGridView.
                    dataGridView1.DataSource = dataTable;

                    // Cerrar la conexión y el Recordset.
                    recordset.Close();


                    connection.Close();

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // Manejar el error apropiadamente, por ejemplo, mostrar un mensaje de error al usuario
                }

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
