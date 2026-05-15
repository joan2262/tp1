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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            textTelefono.PlaceholderText = "DNI";
            textTelefono.Size = new Size(115, 23);
            textTelefono.TabIndex = 9;
            // 
            // textDNI
            // 
            textDNI.Location = new Point(416, 244);
            textDNI.Name = "textDNI";
            textDNI.PlaceholderText = "Telefono";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 205);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 205);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 15;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 205);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 205);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 17;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(757, 205);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 18;
            label5.Text = "Cargo";
            // 
            // Form4Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 595);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}