namespace WinFormsApp008_BuscadorDeProductos
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
            button1 = new Button();
            txtCaja = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOutCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(262, 31);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCaja
            // 
            txtCaja.Location = new Point(16, 32);
            txtCaja.Margin = new Padding(2, 2, 2, 2);
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(173, 23);
            txtCaja.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 90);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // txtOutCodigo
            // 
            txtOutCodigo.Location = new Point(16, 108);
            txtOutCodigo.Name = "txtOutCodigo";
            txtOutCodigo.Size = new Size(93, 23);
            txtOutCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(93, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(354, 108);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(101, 23);
            txtPrecio.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtOutCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCaja);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Buscador";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtCaja;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOutCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
    }
}
