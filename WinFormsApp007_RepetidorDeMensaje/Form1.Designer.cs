namespace WinFormsApp007_RepetidorDeMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblMensaje = new Label();
            lblNumeroRepeticiones = new Label();
            btnEjecutar = new Button();
            lstMensajes = new ListBox();
            txtMensaje = new TextBox();
            txtNumeroRepeticiones = new TextBox();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(29, 40);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 25);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Mensaje:";
            // 
            // lblNumeroRepeticiones
            // 
            lblNumeroRepeticiones.AutoSize = true;
            lblNumeroRepeticiones.Location = new Point(29, 93);
            lblNumeroRepeticiones.Name = "lblNumeroRepeticiones";
            lblNumeroRepeticiones.Size = new Size(206, 25);
            lblNumeroRepeticiones.TabIndex = 1;
            lblNumeroRepeticiones.Text = "Numero de repeticiones:";
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(641, 88);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(112, 34);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lstMensajes
            // 
            lstMensajes.FormattingEnabled = true;
            lstMensajes.ItemHeight = 25;
            lstMensajes.Location = new Point(29, 138);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(724, 279);
            lstMensajes.TabIndex = 3;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(116, 37);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(637, 31);
            txtMensaje.TabIndex = 4;
            // 
            // txtNumeroRepeticiones
            // 
            txtNumeroRepeticiones.Location = new Point(237, 87);
            txtNumeroRepeticiones.Name = "txtNumeroRepeticiones";
            txtNumeroRepeticiones.Size = new Size(152, 31);
            txtNumeroRepeticiones.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeroRepeticiones);
            Controls.Add(txtMensaje);
            Controls.Add(lstMensajes);
            Controls.Add(btnEjecutar);
            Controls.Add(lblNumeroRepeticiones);
            Controls.Add(lblMensaje);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Repetidor De Mensaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblNumeroRepeticiones;
        private Button btnEjecutar;
        private ListBox lstMensajes;
        private TextBox txtMensaje;
        private TextBox txtNumeroRepeticiones;
    }
}
