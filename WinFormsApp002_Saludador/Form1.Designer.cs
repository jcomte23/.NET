namespace WinFormsApp002_Saludador
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
            btnMostrarMensaje = new Button();
            txtMensaje = new TextBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnMostrarMensaje
            // 
            btnMostrarMensaje.Location = new Point(321, 219);
            btnMostrarMensaje.Name = "btnMostrarMensaje";
            btnMostrarMensaje.Size = new Size(154, 55);
            btnMostrarMensaje.TabIndex = 0;
            btnMostrarMensaje.Text = "Mostrar Mensaje";
            btnMostrarMensaje.UseVisualStyleBackColor = true;
            btnMostrarMensaje.Click += btnMostrarMensaje_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(287, 160);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(224, 27);
            txtMensaje.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(271, 128);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(266, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "Coloca el mensaje que quieres mostrar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(txtMensaje);
            Controls.Add(btnMostrarMensaje);
            Name = "Form1";
            Text = "Saludador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarMensaje;
        private TextBox txtMensaje;
        private Label lblMensaje;
    }
}
