namespace navegacion
{
    partial class Form5
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
            btnForm5Volver = new Button();
            SuspendLayout();
            // 
            // btnForm5Volver
            // 
            btnForm5Volver.Location = new Point(216, 340);
            btnForm5Volver.Name = "btnForm5Volver";
            btnForm5Volver.Size = new Size(176, 42);
            btnForm5Volver.TabIndex = 0;
            btnForm5Volver.Text = "Volver";
            btnForm5Volver.UseVisualStyleBackColor = true;
            btnForm5Volver.Click += btnForm5Volver_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm5Volver);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm5Volver;
    }
}