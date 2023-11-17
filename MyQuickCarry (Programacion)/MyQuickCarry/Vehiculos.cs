using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_QuickCarry
{
    public partial class Vehiculos : Form
    {

        Connection conexion = new Connection();
        Recordset recordset1 = new Recordset();
        Recordset recordset2 = new Recordset();
        public Vehiculos()
        {
            InitializeComponent();
            conexion.ConnectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            CargarGrids();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrids()
        {

            string query1 = "SELECT matricula, capacidad_M3, capacidad_KG FROM camion";

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
            datagridcamiones.DataSource = dataTable;

            recordset1.Close();
            conexion.Close();



            conexion.Open();

            string query2 = "SELECT matricula, capacidad_M3, capacidad_KG FROM camioneta";

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
            datagridcamionetas.DataSource = dataTable2;

            // Cerrar la conexión y el Recordset.

            recordset2.Close();


            // Refrescar y actualizar el DataGridView.
            datagridcamiones.Refresh();
            datagridcamionetas.Refresh();

            conexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
