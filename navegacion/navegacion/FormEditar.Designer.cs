namespace navegacion
{
    partial class Form4Editar
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
            btnForm4Volver = new Button();
            textCargo = new TextBox();
            textTelefono = new TextBox();
            textDNI = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            Lbl1 = new Label();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // btnForm4Volver
            // 
            btnForm4Volver.Location = new Point(12, 551);
            btnForm4Volver.Name = "btnForm4Volver";
            btnForm4Volver.Size = new Size(145, 32);
            btnForm4Volver.TabIndex = 0;
            btnForm4Volver.Text = "Volver";
            btnForm4Volver.UseVisualStyleBackColor = true;
            btnForm4Volver.Click += btnForm4Volver_Click;
            // 
            // textCargo
            // 
            textCargo.Location = new Point(730, 244);
            textCargo.Name = "textCargo";
            textCargo.PlaceholderText = "Cargo";
            textCargo.Size = new Size(115, 23);
            textCargo.TabIndex = 10;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(579, 244);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(115, 23);
            textTelefono.TabIndex = 9;
            // 
            // textDNI
            // 
            textDNI.Location = new Point(416, 244);
            textDNI.Name = "textDNI";
            textDNI.PlaceholderText = "DNI";
            textDNI.Size = new Size(115, 23);
            textDNI.TabIndex = 8;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(264, 244);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(115, 23);
            textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(103, 244);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(115, 23);
            textNombre.TabIndex = 6;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(416, 142);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(119, 15);
            Lbl1.TabIndex = 12;
            Lbl1.Text = "Agregar correcciones";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(103, 358);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(742, 35);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "EditarGOOOD";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form4Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 595);
            Controls.Add(btnEditar);
            Controls.Add(Lbl1);
            Controls.Add(textCargo);
            Controls.Add(textTelefono);
            Controls.Add(textDNI);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(btnForm4Volver);
            Name = "Form4Editar";
            Text = "+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnForm4Volver;
        private TextBox textCargo;
        private TextBox textTelefono;
        private TextBox textDNI;
        private TextBox textApellido;
        private TextBox textNombre;
        private Label Lbl1;
        private Button btnEditar;
    }
}