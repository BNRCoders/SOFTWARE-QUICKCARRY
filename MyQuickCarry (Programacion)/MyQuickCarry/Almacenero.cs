using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace My_QuickCarry
{
    public partial class Almacenero : Form
    {
        private Connection conexion = new Connection();

        private Recordset recordset1 = new Recordset();
        private DataTable dataTable1;

        // Crea una nueva columna de CheckBox






        public Almacenero()
        {
            InitializeComponent();
            conexion.ConnectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datagridpaquetes.Columns["chkColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chk = datagridpaquetes.Rows[e.RowIndex].Cells["chkColumn"] as DataGridViewCheckBoxCell;

                if (chk.Value == null)
                {
                    chk.Value = true;
                }
                else if ((bool)chk.Value)
                {
                    chk.Value = false;
                }
                else
                {
                    chk.Value = true;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Almacenero_Load(object sender, EventArgs e)
        {
            CargarGrids();

            conexion.Open();
            string query = "SELECT nombre_usuario FROM cliente;";
            Recordset recordset2 = new Recordset();
            recordset2.Open(query, conexion, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly);

            while (!recordset2.EOF)
            {
                comboCliente.Items.Add(recordset2.Fields["nombre_usuario"].Value.ToString());
                recordset2.MoveNext();
            }
            recordset2.Close();
            conexion.Close();


            // Agregar columna de CheckBox al DataGridView
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seleccionar";
            checkBoxColumn.Name = "chkColumn";
            // Antes o después de agregar la columna de CheckBox, desactiva la adición automática de filas en blanco
            datagridpaquetes.AllowUserToAddRows = false;

            datagridpaquetes.Columns.Add(checkBoxColumn);


        }

        private void CargarGrids()
        {

            string query1 = "SELECT P.id_paquete, P.Peso_KG, P.Volumen_M3, P.estado, C.nombre_usuario FROM Paquete AS P INNER JOIN cliente_paquete AS CP ON P.id_paquete = CP.id_paquete INNER JOIN cliente AS C ON CP.id = C.id;";

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
            datagridpaquetes.DataSource = dataTable;

            recordset1.Close();
            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string direccion = txtDireccion.Text;
            decimal peso = decimal.Parse(txtPeso.Text);
            decimal volumen = decimal.Parse(txtVolumen.Text);
            string cliente = comboCliente.Text;

            conexion.Open();

            string insertQuery = $"INSERT INTO Paquete (peso_KG, Volumen_M3, estado) VALUES ({peso}, {volumen}, 'pendiente');";

            Command command = new Command();
            command.ActiveConnection = conexion;
            command.CommandText = insertQuery;
            command.Execute(out var _, 0);

            string insertQuery2 = $"INSERT INTO cliente_paquete (id_paquete, id, direccion) VALUES ((select MAX(id_paquete) from paquete ), (select id from cliente where nombre_usuario = '{cliente}'), '{direccion}');";

            command.ActiveConnection = conexion;
            command.CommandText = insertQuery2;
            command.Execute(out var _, 0);

            conexion.Close();

            CargarGrids();

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {




            foreach (DataGridViewRow row in datagridpaquetes.Rows)
            {
                if (row.Cells["chkColumn"].Value != null && (bool)row.Cells["chkColumn"].Value == true)
                {


                }
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            decimal peso = decimal.Parse(txtPeso.Text);
            decimal volumen = decimal.Parse(txtVolumen.Text);
            string cliente = comboCliente.Text;

            conexion.Open();

            string insertQuery = $"INSERT INTO Paquete (peso_KG, Volumen_M3, estado) VALUES ({peso}, {volumen}, 'pendiente');";

            Command command = new Command();
            command.ActiveConnection = conexion;
            command.CommandText = insertQuery;
            command.Execute(out var _, 0);

            string insertQuery2 = $"INSERT INTO cliente_paquete (id_paquete, id, direccion) VALUES ((select MAX(id_paquete) from Paquete ), (select id from cliente where nombre_usuario = '{cliente}'), '{direccion}');";

            command.ActiveConnection = conexion;
            command.CommandText = insertQuery2;
            command.Execute(out var _, 0);

            conexion.Close();

            CargarGrids();
        }

        private void comboCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Supongamos que tu DataGridView se llama dataGridView1
            if (datagridpaquetes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridpaquetes.SelectedRows[0];
                int idToDelete = Convert.ToInt32(selectedRow.Cells["id_paquete"].Value);
                // Continuar con la eliminación utilizando el idToDelete
               
                    // Suponiendo que ya tienes una conexión abierta llamada 'conexion'
                    string deleteQuery = $"DELETE FROM Paquete WHERE id_paquete = {idToDelete}";
                Command command = new Command();
                command.ActiveConnection = conexion;
                command.CommandText = deleteQuery;
                    command.Execute(out var _, 0);

                    // Actualizar el DataGridView después de la eliminación
                    CargarGrids(); // Implementa este método para cargar nuevamente los datos en el DataGridView
                }
                

            }



        }
    }

