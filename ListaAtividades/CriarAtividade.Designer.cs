namespace ListaAtividades
{
    partial class CriarAtividade
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
            label1 = new Label();
            buttonDescartar = new Button();
            textBoxTitulo = new TextBox();
            buttonCriar = new Button();
            groupBox1 = new GroupBox();
            labelErro = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 223);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(236, 270);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 1;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(264, 241);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 2;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(317, 270);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 3;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 437);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(20, 404);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "label2";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonDescartar;
        private TextBox textBoxTitulo;
        private Button buttonCriar;
        private GroupBox groupBox1;
        private Label labelErro;
    }
}