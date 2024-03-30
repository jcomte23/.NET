namespace WinFormsApp007_RepetidorDeMensajes
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
            lblCantidadRepeticiones = new Label();
            txtMensaje = new TextBox();
            txtRepeticiones = new TextBox();
            lstRepeticiones = new ListBox();
            btnEjecutar = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            resources.ApplyResources(lblMensaje, "lblMensaje");
            lblMensaje.Name = "lblMensaje";
            // 
            // lblCantidadRepeticiones
            // 
            resources.ApplyResources(lblCantidadRepeticiones, "lblCantidadRepeticiones");
            lblCantidadRepeticiones.Name = "lblCantidadRepeticiones";
            // 
            // txtMensaje
            // 
            resources.ApplyResources(txtMensaje, "txtMensaje");
            txtMensaje.Name = "txtMensaje";
            // 
            // txtRepeticiones
            // 
            resources.ApplyResources(txtRepeticiones, "txtRepeticiones");
            txtRepeticiones.Name = "txtRepeticiones";
            // 
            // lstRepeticiones
            // 
            resources.ApplyResources(lstRepeticiones, "lstRepeticiones");
            lstRepeticiones.FormattingEnabled = true;
            lstRepeticiones.Name = "lstRepeticiones";
            // 
            // btnEjecutar
            // 
            resources.ApplyResources(btnEjecutar, "btnEjecutar");
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEjecutar);
            Controls.Add(lstRepeticiones);
            Controls.Add(txtRepeticiones);
            Controls.Add(txtMensaje);
            Controls.Add(lblCantidadRepeticiones);
            Controls.Add(lblMensaje);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblCantidadRepeticiones;
        private TextBox txtMensaje;
        private TextBox txtRepeticiones;
        private ListBox lstRepeticiones;
        private Button btnEjecutar;
    }
}
