namespace navegacion
{
    partial class Form3
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
            btnForm3Volver = new Button();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDNI = new TextBox();
            textTelefono = new TextBox();
            textCargo = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // btnForm3Volver
            // 
            btnForm3Volver.Location = new Point(12, 561);
            btnForm3Volver.Name = "btnForm3Volver";
            btnForm3Volver.Size = new Size(122, 29);
            btnForm3Volver.TabIndex = 0;
            btnForm3Volver.Text = "Volver";
            btnForm3Volver.UseVisualStyleBackColor = true;
            btnForm3Volver.Click += btnForm3Volver_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(116, 239);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(115, 23);
            textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(275, 239);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(115, 23);
            textApellido.TabIndex = 2;
            // 
            // textDNI
            // 
            textDNI.Location = new Point(427, 239);
            textDNI.Name = "textDNI";
            textDNI.PlaceholderText = "DNI";
            textDNI.Size = new Size(115, 23);
            textDNI.TabIndex = 3;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(591, 239);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(115, 23);
            textTelefono.TabIndex = 4;
            // 
            // textCargo
            // 
            textCargo.Location = new Point(743, 239);
            textCargo.Name = "textCargo";
            textCargo.PlaceholderText = "Cargo";
            textCargo.Size = new Size(115, 23);
            textCargo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(116, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(742, 35);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 602);
            Controls.Add(btnAgregar);
            Controls.Add(textCargo);
            Controls.Add(textTelefono);
            Controls.Add(textDNI);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(btnForm3Volver);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnForm3Volver;
        private Button btnVolverForm3;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDNI;
        private TextBox textTelefono;
        private TextBox textCargo;
        private Button btnAgregar;
    }
}