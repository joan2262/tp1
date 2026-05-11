namespace navegacion
{
    partial class FormMostrar
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
            btnCambiarForm2 = new Button();
            dgvEmpleados = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnCambiarForm2
            // 
            btnCambiarForm2.Location = new Point(12, 562);
            btnCambiarForm2.Name = "btnCambiarForm2";
            btnCambiarForm2.Size = new Size(130, 29);
            btnCambiarForm2.TabIndex = 0;
            btnCambiarForm2.Text = "Volver";
            btnCambiarForm2.UseVisualStyleBackColor = true;
            btnCambiarForm2.Click += btnCambiarForm2_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, dni, telefono, cargo });
            dgvEmpleados.Location = new Point(153, 104);
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(710, 225);
            dgvEmpleados.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // dni
            // 
            dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // cargo
            // 
            cargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cargo.HeaderText = "Cargo";
            cargo.Name = "cargo";
            cargo.ReadOnly = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(733, 347);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(130, 29);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminiar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(581, 347);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(130, 29);
            BtnEditar.TabIndex = 3;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += buttonEditarForm3_Click;
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 603);
            Controls.Add(BtnEditar);
            Controls.Add(BtnEliminar);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnCambiarForm2);
            Name = "FormMostrar";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCambiarForm2;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn cargo;
        private Button BtnEliminar;
        private Button BtnEditar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}