using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_QuickCarry
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            // Código de inicialización
        }

        private void FormAdmin_Resize(object sender, EventArgs e)
        {
            int panelWidth = 300;
            int panelHeight = 200;
            int panelX = (this.Width - panelWidth) / 2;
            int panelY = (this.Height - panelHeight) / 2;

            panel1.Width = panelWidth;
            panel1.Height = panelHeight;
            panel1.Location = new Point(panelX, panelY);
        }

        private void FormLogin_FormClosing(Object sender, FormClosingEventArgs e)
        { 
            formLogin formLogin = new formLogin();
            formLogin.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Código del evento
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Código del evento
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Código del evento
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Código del evento
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Usuarios());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Almacenero());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Código del evento
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Código del evento
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Almacenes());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form formLogin = new Form();
            formLogin.Show();
            this.Close();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {
            // Código del evento
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vehiculos());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
