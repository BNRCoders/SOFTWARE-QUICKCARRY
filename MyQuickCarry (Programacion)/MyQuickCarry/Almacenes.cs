using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_QuickCarry
{
    public partial class Almacenes : Form
    {


       
        private Recordset recordset1 = new Recordset();
        private DataTable dataTable1;


        private Recordset recordset2 = new Recordset();
        private DataTable dataTable2;

    
        private Recordset recordset3 = new Recordset();
        private DataTable dataTable3;

       
        private Recordset recordset4 = new Recordset();
        private DataTable dataTable4;

        private Connection conexion = new Connection();
        public Almacenes()
        {


            InitializeComponent();

            conexion.ConnectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";
            // Configura la cadena de conexión a tu base de datos

        }

        private void LlenarDataGridViewAlmacenQuickcarry()
        {
            string consulta = "SELECT id_interno, Capacidad_M3, Capacidad_KG, Direccion FROM Almacen_quickcarry";
            Recordset rs = new Recordset();

            rs.Open(consulta, conexion, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic);

            // Enlaza el Recordset con el DataGridView
            datagridquickcarry.DataSource = rs;
        }

        private void LlenarDataGridViewAlmacenCrecom()
        {
            string consulta = "SELECT id_interno, Capacidad_M3, Capacidad_KG, Direccion FROM Almacen_crecom";
            Recordset rs = new Recordset();

            rs.Open(consulta, conexion, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic);

            // Enlaza el Recordset con el DataGridView
            datagridcrecom.DataSource = rs;
        }

        private void TuFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conexion.State == 1)
            {
                conexion.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int capacidadM3 = int.Parse(txtCM3Añadir.Text);
            int capacidadKG = int.Parse(txtCKGAñadir.Text);
            string direccion = txtDirecAñadir.Text;
            int nAlmacen = (int)numericAñadir.Value;

            string pertenece = "";

            if (radioCrecom.Checked)
            {
                pertenece = "crecom";
            }
            else if (radioQuickcarry.Checked)
            {
                pertenece = "quickcarry";
            }
            else
            {

                //mostrar cartel que falta un campo
            }




            conexion.Open();

            string insertAlmacenQuery = $"INSERT INTO Almacen (Capacidad_M3, Capacidad_KG, Direccion) VALUES ({capacidadM3}, {capacidadKG}, '{direccion}')";

            Command command = new Command();
            command.ActiveConnection = conexion;
            command.CommandText = insertAlmacenQuery;
            command.Execute(out var _, 0);


            string insertAlmacenPerteneceQuery = $"INSERT INTO Almacen_{pertenece} (id_Almacen, id_interno, Capacidad_M3, Capacidad_KG, Direccion) VALUES ((SELECT MAX(id_Almacen) FROM Almacen), {nAlmacen}, {capacidadM3}, {capacidadKG}, '{direccion}')";

            Command command2 = new Command();
            command2.ActiveConnection = conexion;
            command2.CommandText = insertAlmacenPerteneceQuery;
            command2.Execute(out var _, 0);




            CargarGrids();
            conexion.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtPasswordCrear_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUserCrear_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datagridquickcarry.SelectedRows.Count == 1)
            {
                int rowIndex = datagridquickcarry.SelectedRows[0].Index;
                int id_interno = Convert.ToInt32(datagridquickcarry.Rows[rowIndex].Cells["id_interno"].Value);
                int id_almacen = 0; // Variable para almacenar el valor

                conexion.Open();




                string queryID = $"SELECT id_almacen FROM Almacen_quickcarry WHERE id_interno = '{id_interno}'";
                string queryAlmacen_quickcarry = $"DELETE FROM Almacen_quickcarry WHERE id_interno = {id_interno};";
                string queryAlmacen = $"DELETE FROM Almacen WHERE id_Almacen = ({id_almacen});";

                Command command = new Command();

                command.ActiveConnection = conexion;
                command.CommandText = queryID;
                var rs = command.Execute(out var _, 0);



                if (!rs.EOF)
                {
                    id_almacen = Convert.ToInt32(rs.Fields["id_almacen"].Value);
                }

                command.ActiveConnection = conexion;
                command.CommandText = queryAlmacen;
                command.Execute(out var _, 0);


                command.ActiveConnection = conexion;
                command.CommandText = queryAlmacen_quickcarry;
                command.Execute(out var _, 0);

                conexion.Close();


            }

            if (datagridcrecom.SelectedRows.Count == 1)
            {
                int rowIndex = datagridcrecom.SelectedRows[0].Index;
                int id_interno = Convert.ToInt32(datagridcrecom.Rows[rowIndex].Cells["id_interno"].Value);
                int id_almacen = 0; // Variable para almacenar el valor


                conexion.Open();

                string queryID = $"SELECT id_almacen FROM Almacen_quickcarry WHERE id_interno = '{id_interno}'";
                string queryAlmacen_crecom = $"DELETE FROM Almacen_crecom WHERE id_interno = {id_interno};";
                string queryAlmacen = $"DELETE FROM Almacen WHERE id_Almacen = ({id_almacen});";

                Command command = new Command();

                command.ActiveConnection = conexion;
                command.CommandText = queryID;
                var rs = command.Execute(out var _, 0);



                if (!rs.EOF)
                {
                    id_almacen = Convert.ToInt32(rs.Fields["id_almacen"].Value);
                }



                command.ActiveConnection = conexion;
                command.CommandText = queryAlmacen;
                command.Execute(out var _, 0);


                command.ActiveConnection = conexion;
                command.CommandText = queryAlmacen_crecom;
                command.Execute(out var _, 0);

                conexion.Close();



            }

            CargarGrids();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridcrecom.ClearSelection();

        }

        private void Almacenes_Load(object sender, EventArgs e)
        {

            CargarGrids();

        }

        private void CargarGrids()
        {

            string query1 = "SELECT id_interno, Capacidad_M3, Capacidad_KG, Direccion FROM Almacen_quickcarry";

            conexion.Open();

            recordset1.Open(query1, conexion, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

            // Crear un DataTable para almacenar los datos.
            DataTable dataTable = new DataTable();

            // Agregar columnas al DataTable.
            for (int i = 0; i < recordset1.Fields.Count; i++)
            {
                dataTable.Columns.Add(recordset1.Fields[i].Name);
            }

            // Llenar el DataTable con los datos del Recordset.
            while (!recordset1.EOF)
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < recordset1.Fields.Count; i++)
                {
                    row[i] = recordset1.Fields[i].Value;
                }
                dataTable.Rows.Add(row);
                recordset1.MoveNext();
            }

            // Asignar el DataTable como origen de datos para el DataGridView.
            datagridquickcarry.DataSource = dataTable;

            recordset1.Close();
            conexion.Close();



            conexion.Open();

            string query2 = "SELECT id_interno, Capacidad_M3, Capacidad_KG, Direccion FROM Almacen_crecom";

            recordset2.Open(query2, conexion, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic);

            // Crear un DataTable para almacenar los datos.
            DataTable dataTable2 = new DataTable();

            // Agregar columnas al DataTable.
            for (int i = 0; i < recordset2.Fields.Count; i++)
            {
                dataTable2.Columns.Add(recordset2.Fields[i].Name);
            }

            // Llenar el DataTable con los datos del Recordset.
            while (!recordset2.EOF)
            {
                DataRow row = dataTable2.NewRow();
                for (int i = 0; i < recordset2.Fields.Count; i++)
                {
                    row[i] = recordset2.Fields[i].Value;
                }
                dataTable2.Rows.Add(row);
                recordset2.MoveNext();
            }

            // Asignar el DataTable como origen de datos para el DataGridView.
            datagridcrecom.DataSource = dataTable2;

            // Cerrar la conexión y el Recordset.

            recordset2.Close();


            // Refrescar y actualizar el DataGridView.
            datagridquickcarry.Refresh();
            datagridcrecom.Refresh();

            conexion.Close();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void datagridcrecom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridquickcarry.ClearSelection();
        }

        private void datagridquickcarry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (datagridquickcarry.SelectedRows.Count == 1)
{
                int rowIndex = datagridquickcarry.SelectedRows[0].Index;
                int id_interno = Convert.ToInt32(datagridquickcarry.Rows[rowIndex].Cells["id_interno"].Value);
                int id_almacen = 0; // Variable para almacenar el valor

                conexion.Open();

                string queryIDC = $"SELECT id_almacen FROM Almacen_quickcarry WHERE id_interno = '{id_interno}'";
                string queryAlmacen_quickcarry = $"DELETE FROM Almacen_quickcarry WHERE id_interno = {id_interno};";

                Command command = new Command();

                command.ActiveConnection = conexion;
                command.CommandText = queryIDC;
                var rs = command.Execute(out var _, 0);

                // Eliminar la fila de Almacen_crecom
                command.ActiveConnection = conexion;
                command.CommandText = queryAlmacen_quickcarry;
                command.Execute(out var _, 0);

                if (!rs.EOF)
                {
                    id_almacen = Convert.ToInt32(rs.Fields["id_almacen"].Value);

                    // Eliminar la fila de Almacen usando id_almacen obtenido
                    string queryAlmacen = $"DELETE FROM Almacen WHERE id_Almacen = {id_almacen};";
                    command.ActiveConnection = conexion;
                    command.CommandText = queryAlmacen;
                    command.Execute(out var _, 0);
                }


                conexion.Close();
            }

if (datagridcrecom.SelectedRows.Count == 1)
{
    int rowIndex = datagridcrecom.SelectedRows[0].Index;
    int id_interno = Convert.ToInt32(datagridcrecom.Rows[rowIndex].Cells["id_interno"].Value);
    int id_almacen = 0; // Variable para almacenar el valor

    conexion.Open();

    string queryIDC = $"SELECT id_almacen FROM Almacen_crecom WHERE id_interno = '{id_interno}'";
    string queryAlmacen_crecom = $"DELETE FROM Almacen_crecom WHERE id_interno = {id_interno};";

    Command command = new Command();

    command.ActiveConnection = conexion;
    command.CommandText = queryIDC;
    var rs = command.Execute(out var _, 0);

                // Eliminar la fila de Almacen_crecom
                command.ActiveConnection = conexion;
                command.CommandText = queryAlmacen_crecom;
                command.Execute(out var _, 0);

                if (!rs.EOF)
                {
                    id_almacen = Convert.ToInt32(rs.Fields["id_almacen"].Value);

                    // Eliminar la fila de Almacen usando id_almacen obtenido
                    string queryAlmacen = $"DELETE FROM Almacen WHERE id_Almacen = {id_almacen};";
                    command.ActiveConnection = conexion;
                    command.CommandText = queryAlmacen;
                    command.Execute(out var _, 0);
                }


                conexion.Close();
}


            CargarGrids();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int capacidadM3 = int.Parse(txtCM3Añadir.Text);
            int capacidadKG = int.Parse(txtCKGAñadir.Text);
            string direccion = txtDirecAñadir.Text;
            int nAlmacen = (int)numericAñadir.Value;

            string pertenece = "";

            if (radioCrecom.Checked)
            {
                pertenece = "crecom";
            }
            else if (radioQuickcarry.Checked)
            {
                pertenece = "quickcarry";
            }
            else
            {

                //mostrar cartel que falta un campo
            }




            conexion.Open();

            string insertAlmacenQuery = $"INSERT INTO Almacen (Capacidad_M3, Capacidad_KG, Direccion) VALUES ({capacidadM3}, {capacidadKG}, '{direccion}')";

            Command command = new Command();
            command.ActiveConnection = conexion;
            command.CommandText = insertAlmacenQuery;
            command.Execute(out var _, 0);


            string insertAlmacenPerteneceQuery = $"INSERT INTO Almacen_{pertenece} (id_Almacen, id_interno, Capacidad_M3, Capacidad_KG, Direccion) VALUES ((SELECT MAX(id_Almacen) FROM Almacen), {nAlmacen}, {capacidadM3}, {capacidadKG}, '{direccion}')";

            Command command2 = new Command();
            command2.ActiveConnection = conexion;
            command2.CommandText = insertAlmacenPerteneceQuery;
            command2.Execute(out var _, 0);

            conexion.Close();


            CargarGrids();
               
        }
    }
}
