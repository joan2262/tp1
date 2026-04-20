namespace navegacion
{
    partial class Form4
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
            SuspendLayout();
            // 
            // btnForm4Volver
            // 
            btnForm4Volver.Location = new Point(24, 393);
            btnForm4Volver.Name = "btnForm4Volver";
            btnForm4Volver.Size = new Size(145, 32);
            btnForm4Volver.TabIndex = 0;
            btnForm4Volver.Text = "Volver";
            btnForm4Volver.UseVisualStyleBackColor = true;
            btnForm4Volver.Click += btnForm4Volver_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm4Volver);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm4Volver;
    }
}