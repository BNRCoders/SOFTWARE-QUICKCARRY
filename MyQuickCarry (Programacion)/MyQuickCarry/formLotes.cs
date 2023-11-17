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

namespace MyQuickCarry
{
    public partial class formLotes : Form
    {

        private Connection conexion = new Connection();
        private Recordset recordset1 = new Recordset();
        private DataTable dataTable1;
        public formLotes()
        {
            InitializeComponent();

            conexion.ConnectionString = "DSN=awdadw;Uid=joaquin.batista;Pwd=55471832;";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string idLote;
            if (dataGridLotes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridLotes.SelectedRows[0];

                // Obtener el valor de la celda "id_lote" en la fila seleccionada (suponiendo que el nombre de la columna es "id_lote")
                idLote = filaSeleccionada.Cells["id_lote"].Value.ToString();

                // Aquí puedes usar el valor de idLote como desees, por ejemplo, guardarlo en una variable, en una base de datos, etc.
                // Ejemplo de uso:
                // GuardarEnBaseDeDatos(idLote);
            }
            else
            {
                // En caso de que no haya una fila seleccionada, puedes mostrar un mensaje o realizar alguna acción para informar al usuario.
                MessageBox.Show("Por favor, selecciona una fila antes de guardar.");
            }

          


        }

        private void formLotes_Load(object sender, EventArgs e)
        {
            CargarGrids();
        }

        private void CargarGrids()
        {

            string query1 = "SELECT id_lote, Peso_KG, Volumen_M3, estado from Lote;";

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
            dataGridLotes.DataSource = dataTable;

            recordset1.Close();
            conexion.Close();




            // Refrescar y actualizar el DataGridView.
            dataGridLotes.Refresh();
           
        }
    }
}
