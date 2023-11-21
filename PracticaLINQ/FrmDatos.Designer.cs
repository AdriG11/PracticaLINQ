namespace PracticaLINQ
{
    partial class FrmDatos
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            cmbRaza = new ComboBox();
            dgvDatos = new DataGridView();
            tsmMenu = new ToolStrip();
            tslRegistrar = new ToolStripLabel();
            tlsConsultar = new ToolStripLabel();
            tlsEliminar = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            tslAcercade = new ToolStripLabel();
            erpError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 173);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 91);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(289, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(289, 166);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 4;
            // 
            // cmbRaza
            // 
            cmbRaza.FormattingEnabled = true;
            cmbRaza.Items.AddRange(new object[] { "", "Pastor Aleman", "Husky", "Doberman", "Labrador" });
            cmbRaza.Location = new Point(289, 91);
            cmbRaza.Name = "cmbRaza";
            cmbRaza.Size = new Size(151, 28);
            cmbRaza.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(42, 241);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.Size = new Size(816, 252);
            dgvDatos.TabIndex = 6;
            // 
            // tsmMenu
            // 
            tsmMenu.ImageScalingSize = new Size(20, 20);
            tsmMenu.Items.AddRange(new ToolStripItem[] { tslRegistrar, tlsConsultar, tlsEliminar, toolStripLabel1, tslAcercade });
            tsmMenu.Location = new Point(0, 0);
            tsmMenu.Name = "tsmMenu";
            tsmMenu.Size = new Size(963, 25);
            tsmMenu.TabIndex = 7;
            tsmMenu.Text = "toolStrip1";
            // 
            // tslRegistrar
            // 
            tslRegistrar.Name = "tslRegistrar";
            tslRegistrar.Size = new Size(68, 22);
            tslRegistrar.Text = "Registrar";
            tslRegistrar.Click += tslRegistrar_Click;
            // 
            // tlsConsultar
            // 
            tlsConsultar.Name = "tlsConsultar";
            tlsConsultar.Size = new Size(71, 22);
            tlsConsultar.Text = "Consultar";
            // 
            // tlsEliminar
            // 
            tlsEliminar.Name = "tlsEliminar";
            tlsEliminar.Size = new Size(63, 22);
            tlsEliminar.Text = "Eliminar";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(38, 22);
            toolStripLabel1.Text = "Salir";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // tslAcercade
            // 
            tslAcercade.Name = "tslAcercade";
            tslAcercade.Size = new Size(75, 22);
            tslAcercade.Text = "Acerca de";
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // FrmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 564);
            Controls.Add(tsmMenu);
            Controls.Add(dgvDatos);
            Controls.Add(cmbRaza);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDatos";
            Text = "LISTA DE MASCOTAS";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tsmMenu.ResumeLayout(false);
            tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ComboBox cmbRaza;
        private DataGridView dgvDatos;
        private ToolStrip tsmMenu;
        private ToolStripLabel tslRegistrar;
        private ToolStripLabel tlsConsultar;
        private ToolStripLabel tlsEliminar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel tslAcercade;
        private ErrorProvider erpError;
    }
}