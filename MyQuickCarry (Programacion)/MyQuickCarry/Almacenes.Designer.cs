using System.Drawing;
using System.Windows.Forms;

namespace My_QuickCarry
{
    partial class Almacenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirecAñadir = new System.Windows.Forms.TextBox();
            this.txtCKGAñadir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridquickcarry = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridcrecom = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCM3Añadir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioCrecom = new System.Windows.Forms.RadioButton();
            this.radioQuickcarry = new System.Windows.Forms.RadioButton();
            this.numericAñadir = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupboxAlmacen = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridquickcarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcrecom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAñadir)).BeginInit();
            this.groupboxAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label9.Location = new System.Drawing.Point(701, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Eliminar almacen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(621, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "(Selecciona de la lista el almacen que quieras eliminar)";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(863, 115);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(64, 20);
            this.btnAñadir.TabIndex = 33;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Capacidad_KG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Capacidad_M3:";
            // 
            // txtDirecAñadir
            // 
            this.txtDirecAñadir.Location = new System.Drawing.Point(702, 138);
            this.txtDirecAñadir.Name = "txtDirecAñadir";
            this.txtDirecAñadir.Size = new System.Drawing.Size(86, 20);
            this.txtDirecAñadir.TabIndex = 30;
            // 
            // txtCKGAñadir
            // 
            this.txtCKGAñadir.Location = new System.Drawing.Point(702, 113);
            this.txtCKGAñadir.Name = "txtCKGAñadir";
            this.txtCKGAñadir.Size = new System.Drawing.Size(86, 20);
            this.txtCKGAñadir.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label6.Location = new System.Drawing.Point(693, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Añadir almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "(Selecciona de la lista el almacen que quieras modificar)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label1.Location = new System.Drawing.Point(693, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Modificar almacen";
            // 
            // datagridquickcarry
            // 
            this.datagridquickcarry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridquickcarry.Location = new System.Drawing.Point(59, 68);
            this.datagridquickcarry.Name = "datagridquickcarry";
            this.datagridquickcarry.ReadOnly = true;
            this.datagridquickcarry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridquickcarry.Size = new System.Drawing.Size(458, 190);
            this.datagridquickcarry.TabIndex = 20;
            this.datagridquickcarry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridquickcarry_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label2.Location = new System.Drawing.Point(185, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lista de almacenes de Quickcarry";
            // 
            // datagridcrecom
            // 
            this.datagridcrecom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcrecom.Location = new System.Drawing.Point(59, 359);
            this.datagridcrecom.Name = "datagridcrecom";
            this.datagridcrecom.ReadOnly = true;
            this.datagridcrecom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridcrecom.Size = new System.Drawing.Size(458, 190);
            this.datagridcrecom.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label11.Location = new System.Drawing.Point(185, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Lista de almacenes de Crecom";
            // 
            // txtCM3Añadir
            // 
            this.txtCM3Añadir.Location = new System.Drawing.Point(702, 88);
            this.txtCM3Añadir.Name = "txtCM3Añadir";
            this.txtCM3Añadir.Size = new System.Drawing.Size(86, 20);
            this.txtCM3Añadir.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(645, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Dirección:";
            // 
            // radioCrecom
            // 
            this.radioCrecom.AutoSize = true;
            this.radioCrecom.Location = new System.Drawing.Point(87, 10);
            this.radioCrecom.Name = "radioCrecom";
            this.radioCrecom.Size = new System.Drawing.Size(61, 17);
            this.radioCrecom.TabIndex = 41;
            this.radioCrecom.TabStop = true;
            this.radioCrecom.Text = "Crecom";
            this.radioCrecom.UseVisualStyleBackColor = true;
            // 
            // radioQuickcarry
            // 
            this.radioQuickcarry.AutoSize = true;
            this.radioQuickcarry.Location = new System.Drawing.Point(5, 10);
            this.radioQuickcarry.Name = "radioQuickcarry";
            this.radioQuickcarry.Size = new System.Drawing.Size(76, 17);
            this.radioQuickcarry.TabIndex = 42;
            this.radioQuickcarry.TabStop = true;
            this.radioQuickcarry.Text = "Quickcarry";
            this.radioQuickcarry.UseVisualStyleBackColor = true;
            // 
            // numericAñadir
            // 
            this.numericAñadir.Location = new System.Drawing.Point(703, 200);
            this.numericAñadir.Name = "numericAñadir";
            this.numericAñadir.Size = new System.Drawing.Size(33, 20);
            this.numericAñadir.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(597, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Numero de almacen:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(576, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Almacen perteneciente a:";
            // 
            // groupboxAlmacen
            // 
            this.groupboxAlmacen.Controls.Add(this.radioCrecom);
            this.groupboxAlmacen.Controls.Add(this.radioQuickcarry);
            this.groupboxAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupboxAlmacen.Location = new System.Drawing.Point(702, 163);
            this.groupboxAlmacen.Name = "groupboxAlmacen";
            this.groupboxAlmacen.Size = new System.Drawing.Size(150, 32);
            this.groupboxAlmacen.TabIndex = 46;
            this.groupboxAlmacen.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Numero de almacen:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(766, 529);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown2.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(657, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Dirección:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(713, 444);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 52;
            this.button2.Text = "Moficar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(635, 471);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Capacidad_KG:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(633, 446);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Capacidad_M3:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(713, 494);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 49;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(713, 469);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 48;
            // 
            // Almacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupboxAlmacen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericAñadir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCM3Añadir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.datagridcrecom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDirecAñadir);
            this.Controls.Add(this.txtCKGAñadir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridquickcarry);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(351, 22);
            this.Name = "Almacenes";
            this.Text = "Almacenes";
            this.Load += new System.EventHandler(this.Almacenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridquickcarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcrecom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAñadir)).EndInit();
            this.groupboxAlmacen.ResumeLayout(false);
            this.groupboxAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label9;
        private Label label10;
        private Button btnAñadir;
        private Label label7;
        private Label label8;
        private TextBox txtDirecAñadir;
        private TextBox txtCKGAñadir;
        private Label label6;
        private Button btnActualizar;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUser;
        private DataGridView datagridquickcarry;
        private Label label2;
        private DataGridView datagridcrecom;
        private Label label11;
        private TextBox textBox1;
        private Label label12;
        private RadioButton radioCrecom;
        private RadioButton radioQuickcarry;
        private NumericUpDown numericAñadir;
        private Label label13;
        private Label label14;
        private GroupBox groupboxAlmacen;
        private NumericUpDown numericUpDown2;
        private Label label15;
        private TextBox textBox2;
        private Button button2;
        private Label label16;
        private Label label17;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtCM3Añadir;
    }
}