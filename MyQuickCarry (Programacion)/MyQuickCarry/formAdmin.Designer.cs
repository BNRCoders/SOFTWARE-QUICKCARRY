using ADODB;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace My_QuickCarry
{
    partial class formAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private Panel panel2;
        private Button btnCerrar;
        private Label label3;
        private Button btnPaquetes;
        private Button button2;
        private Button btnAlmacenes;
        private Button btnUsuarios;
        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelContenido;
        private DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaquetes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAlmacenes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panelContenido);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 643);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelContenido
            // 
            this.panelContenido.Location = new System.Drawing.Point(190, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1041, 643);
            this.panelContenido.TabIndex = 2;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPaquetes);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAlmacenes);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 643);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(27, 444);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 29);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar cesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Administración";
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPaquetes.BackgroundImage = global::MyQuickCarry.Properties.Resources.botonblanco;
            this.btnPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaquetes.FlatAppearance.BorderSize = 0;
            this.btnPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPaquetes.ForeColor = System.Drawing.Color.Black;
            this.btnPaquetes.Image = global::MyQuickCarry.Properties.Resources.paqueteIcono;
            this.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.Location = new System.Drawing.Point(10, 295);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Size = new System.Drawing.Size(165, 49);
            this.btnPaquetes.TabIndex = 4;
            this.btnPaquetes.Text = "Paquetes";
            this.btnPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaquetes.UseVisualStyleBackColor = false;
            this.btnPaquetes.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.BackgroundImage = global::MyQuickCarry.Properties.Resources.botonblanco;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::MyQuickCarry.Properties.Resources.icons8_lorry_78;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Vehiculos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlmacenes
            // 
            this.btnAlmacenes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlmacenes.BackgroundImage = global::MyQuickCarry.Properties.Resources.botonblanco;
            this.btnAlmacenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacenes.FlatAppearance.BorderSize = 0;
            this.btnAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAlmacenes.ForeColor = System.Drawing.Color.Black;
            this.btnAlmacenes.Image = global::MyQuickCarry.Properties.Resources.icons8_almacenar;
            this.btnAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacenes.Location = new System.Drawing.Point(9, 187);
            this.btnAlmacenes.Name = "btnAlmacenes";
            this.btnAlmacenes.Size = new System.Drawing.Size(166, 49);
            this.btnAlmacenes.TabIndex = 3;
            this.btnAlmacenes.Text = "Almacenes";
            this.btnAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlmacenes.UseVisualStyleBackColor = false;
            this.btnAlmacenes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.BackgroundImage = global::MyQuickCarry.Properties.Resources.botonblanco;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = global::MyQuickCarry.Properties.Resources.usuarioIcono;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(9, 135);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(166, 47);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "My QuickCarry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backoffice ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQuickCarry.Properties.Resources.fondoInicio1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 643);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

