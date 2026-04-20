namespace navegacion
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
            labelCartel = new Label();
            btnFormVerEmpleados = new Button();
            btnFormAgregarEmpleados = new Button();
            btnFormEditarEmpleados = new Button();
            btnFormBorrarEmpleados = new Button();
            SuspendLayout();
            // 
            // labelCartel
            // 
            labelCartel.AutoSize = true;
            labelCartel.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCartel.Location = new Point(37, 28);
            labelCartel.Name = "labelCartel";
            labelCartel.Size = new Size(961, 77);
            labelCartel.TabIndex = 0;
            labelCartel.Text = "Administración de restaurante";
            // 
            // btnFormVerEmpleados
            // 
            btnFormVerEmpleados.Location = new Point(375, 163);
            btnFormVerEmpleados.Name = "btnFormVerEmpleados";
            btnFormVerEmpleados.Size = new Size(263, 49);
            btnFormVerEmpleados.TabIndex = 1;
            btnFormVerEmpleados.Text = "Ver empleados";
            btnFormVerEmpleados.UseVisualStyleBackColor = true;
            btnFormVerEmpleados.Click += btnFormVerEmpleados_Click;
            // 
            // btnFormAgregarEmpleados
            // 
            btnFormAgregarEmpleados.Location = new Point(375, 235);
            btnFormAgregarEmpleados.Name = "btnFormAgregarEmpleados";
            btnFormAgregarEmpleados.Size = new Size(265, 49);
            btnFormAgregarEmpleados.TabIndex = 2;
            btnFormAgregarEmpleados.Text = "Agregar empleados";
            btnFormAgregarEmpleados.UseVisualStyleBackColor = true;
            btnFormAgregarEmpleados.Click += btnFormAgregarEmpleados_Click;
            // 
            // btnFormEditarEmpleados
            // 
            btnFormEditarEmpleados.Location = new Point(375, 371);
            btnFormEditarEmpleados.Name = "btnFormEditarEmpleados";
            btnFormEditarEmpleados.Size = new Size(262, 47);
            btnFormEditarEmpleados.TabIndex = 3;
            btnFormEditarEmpleados.Text = "Editar empleados";
            btnFormEditarEmpleados.UseVisualStyleBackColor = true;
            btnFormEditarEmpleados.Click += btnFormEditarEmpleados_Click;
            // 
            // btnFormBorrarEmpleados
            // 
            btnFormBorrarEmpleados.Location = new Point(375, 301);
            btnFormBorrarEmpleados.Name = "btnFormBorrarEmpleados";
            btnFormBorrarEmpleados.Size = new Size(262, 48);
            btnFormBorrarEmpleados.TabIndex = 4;
            btnFormBorrarEmpleados.Text = "Eliminar empleados";
            btnFormBorrarEmpleados.UseVisualStyleBackColor = true;
            btnFormBorrarEmpleados.Click += btnFormBorrarEmpleados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 602);
            Controls.Add(btnFormBorrarEmpleados);
            Controls.Add(btnFormEditarEmpleados);
            Controls.Add(btnFormAgregarEmpleados);
            Controls.Add(btnFormVerEmpleados);
            Controls.Add(labelCartel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCartel;
        private Button btnFormVerEmpleados;
        private Button btnFormAgregarEmpleados;
        private Button btnFormEditarEmpleados;
        private Button btnFormBorrarEmpleados;
    }
}
