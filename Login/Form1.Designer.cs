namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Entrar = new Button();
            label3 = new Label();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(242, 203);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(182, 23);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(242, 264);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(182, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 206);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuário :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(176, 267);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha :";
            // 
            // Entrar
            // 
            Entrar.BackColor = Color.Transparent;
            Entrar.Location = new Point(322, 340);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(92, 23);
            Entrar.TabIndex = 4;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(176, 344);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Esqueceu a senha?";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Transparent;
            labelResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(209, 396);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(20, 21);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "- ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(610, 571);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(Entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
        private Button Entrar;
        private Label label3;
        private Label labelResultado;
    }
}