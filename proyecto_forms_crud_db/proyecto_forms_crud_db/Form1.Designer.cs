namespace proyecto_forms_crud_db
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFormAgregar = new Button();
            btnFormEliminar = new Button();
            btnFormEditar = new Button();
            labelCartel = new Label();
            btnFormVer = new Button();
            SuspendLayout();
            // 
            // btnFormAgregar
            // 
            btnFormAgregar.Location = new Point(300, 283);
            btnFormAgregar.Name = "btnFormAgregar";
            btnFormAgregar.Size = new Size(102, 53);
            btnFormAgregar.TabIndex = 0;
            btnFormAgregar.Text = "Agregar empleado";
            btnFormAgregar.UseVisualStyleBackColor = true;
            btnFormAgregar.UseWaitCursor = true;

            // 
            // btnFormEliminar
            // 
            btnFormEliminar.Location = new Point(519, 283);
            btnFormEliminar.Name = "btnFormEliminar";
            btnFormEliminar.Size = new Size(107, 53);
            btnFormEliminar.TabIndex = 1;
            btnFormEliminar.Text = "Eliminar empleado";
            btnFormEliminar.UseVisualStyleBackColor = true;
            btnFormEliminar.UseWaitCursor = true;
            // 
            // btnFormEditar
            // 
            btnFormEditar.Location = new Point(408, 283);
            btnFormEditar.Name = "btnFormEditar";
            btnFormEditar.Size = new Size(105, 53);
            btnFormEditar.TabIndex = 2;
            btnFormEditar.Text = "Editar empleado";
            btnFormEditar.UseVisualStyleBackColor = true;
            btnFormEditar.UseWaitCursor = true;
            // 
            // labelCartel
            // 
            labelCartel.AutoSize = true;
            labelCartel.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCartel.Location = new Point(43, 103);
            labelCartel.Name = "labelCartel";
            labelCartel.Size = new Size(844, 59);
            labelCartel.TabIndex = 3;
            labelCartel.Text = "Administración de restaurante";
            labelCartel.UseWaitCursor = true;
            // 
            // btnFormVer
            // 
            btnFormVer.Location = new Point(300, 224);
            btnFormVer.Name = "btnFormVer";
            btnFormVer.Size = new Size(326, 53);
            btnFormVer.TabIndex = 4;
            btnFormVer.Text = "Ver empleados";
            btnFormVer.UseVisualStyleBackColor = true;
            btnFormVer.UseWaitCursor = true;
            btnFormVer.Click += btnFormVer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(btnFormVer);
            Controls.Add(labelCartel);
            Controls.Add(btnFormEditar);
            Controls.Add(btnFormEliminar);
            Controls.Add(btnFormAgregar);
            Name = "Form1";
            Text = "Agregar empleado";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormAgregar;
        private Button btnFormEliminar;
        private Button btnFormEditar;
        private Label labelCartel;
        private Button btnFormVer;
    }
}
