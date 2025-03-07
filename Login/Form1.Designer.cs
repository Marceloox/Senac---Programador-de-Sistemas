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
            label4 = new Label();
            textBoxnovoUsuario = new TextBox();
            textBoxnovaSenha = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonCadastrar = new Button();
            labelCadastro = new Label();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 89);
            label4.Name = "label4";
            label4.Size = new Size(94, 40);
            label4.TabIndex = 7;
            label4.Text = "Login";
            // 
            // textBoxnovoUsuario
            // 
            textBoxnovoUsuario.Location = new Point(861, 203);
            textBoxnovoUsuario.Name = "textBoxnovoUsuario";
            textBoxnovoUsuario.Size = new Size(139, 23);
            textBoxnovoUsuario.TabIndex = 8;
            // 
            // textBoxnovaSenha
            // 
            textBoxnovaSenha.Location = new Point(861, 264);
            textBoxnovaSenha.Name = "textBoxnovaSenha";
            textBoxnovaSenha.Size = new Size(139, 23);
            textBoxnovaSenha.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(793, 206);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(801, 267);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Senha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(809, 89);
            label7.Name = "label7";
            label7.Size = new Size(203, 40);
            label7.TabIndex = 12;
            label7.Text = "Novo usuario";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(870, 336);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 13;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.BackColor = Color.Transparent;
            labelCadastro.Location = new Point(809, 402);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(12, 15);
            labelCadastro.TabIndex = 14;
            labelCadastro.Text = "-\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1177, 571);
            Controls.Add(labelCadastro);
            Controls.Add(buttonCadastrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxnovaSenha);
            Controls.Add(textBoxnovoUsuario);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox textBoxnovoUsuario;
        private TextBox textBoxnovaSenha;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonCadastrar;
        private Label labelCadastro;
    }
}