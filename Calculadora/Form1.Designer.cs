namespace Calculadora
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
            labelResultado = new Label();
            Numero2 = new TextBox();
            label4 = new Label();
            buttonSoma = new Button();
            Numero1 = new TextBox();
            buttonMult = new Button();
            buttonSub = new Button();
            buttonDiv = new Button();
            label1 = new Label();
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            labelOperacao = new Label();
            comboBoxOpera = new ComboBox();
            textBoxResultado = new TextBox();
            label2 = new Label();
            button1 = new Button();
            labelErro = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(383, 176);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(12, 15);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "?";
            // 
            // Numero2
            // 
            Numero2.Location = new Point(259, 173);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(59, 23);
            Numero2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 74);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 5;
            label4.Text = "Calculadora";
            // 
            // buttonSoma
            // 
            buttonSoma.BackColor = Color.Transparent;
            buttonSoma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSoma.Location = new Point(233, 230);
            buttonSoma.Name = "buttonSoma";
            buttonSoma.Size = new Size(25, 25);
            buttonSoma.TabIndex = 6;
            buttonSoma.Text = "+";
            buttonSoma.UseVisualStyleBackColor = false;
            buttonSoma.Click += buttonSoma_Click;
            // 
            // Numero1
            // 
            Numero1.Location = new Point(139, 173);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(59, 23);
            Numero1.TabIndex = 7;
            // 
            // buttonMult
            // 
            buttonMult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMult.Location = new Point(193, 230);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(25, 25);
            buttonMult.TabIndex = 8;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonSub
            // 
            buttonSub.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSub.Location = new Point(233, 271);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(25, 23);
            buttonSub.TabIndex = 9;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDiv.Location = new Point(193, 271);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(25, 23);
            buttonDiv.TabIndex = 10;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(525, 74);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 11;
            label1.Text = "2º Cálculadora";
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(501, 173);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(76, 23);
            textBoxValor1.TabIndex = 12;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(641, 173);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(76, 23);
            textBoxValor2.TabIndex = 13;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOperacao.Location = new Point(604, 176);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(0, 15);
            labelOperacao.TabIndex = 14;
            // 
            // comboBoxOpera
            // 
            comboBoxOpera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxOpera.FormattingEnabled = true;
            comboBoxOpera.Items.AddRange(new object[] { "Soma", "Subtração", "Multiplicação", "Divisão" });
            comboBoxOpera.Location = new Point(550, 233);
            comboBoxOpera.Name = "comboBoxOpera";
            comboBoxOpera.Size = new Size(121, 25);
            comboBoxOpera.TabIndex = 15;
            comboBoxOpera.Text = "      Operações";
            comboBoxOpera.SelectedIndexChanged += comboBoxOpera_SelectedIndexChanged;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Enabled = false;
            textBoxResultado.Location = new Point(772, 173);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(74, 23);
            textBoxResultado.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(739, 176);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 17;
            label2.Text = "=";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(573, 271);
            button1.Name = "button1";
            button1.Size = new Size(71, 23);
            button1.TabIndex = 18;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(604, 124);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(383, 341);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Novo Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(button2);
            Controls.Add(labelErro);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxResultado);
            Controls.Add(comboBoxOpera);
            Controls.Add(labelOperacao);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Controls.Add(label1);
            Controls.Add(buttonDiv);
            Controls.Add(buttonSub);
            Controls.Add(buttonMult);
            Controls.Add(Numero1);
            Controls.Add(buttonSoma);
            Controls.Add(label4);
            Controls.Add(Numero2);
            Controls.Add(labelResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelOperacao;
        private Label labelResultado;
        private TextBox textBoxValor1;
        private TextBox Numero2;
        private Label label4;
        private Button buttonSoma;
        private TextBox Numero1;
        private Button buttonMult;
        private Button buttonSub;
        private Button buttonDiv;
        private Label label1;
        private TextBox textBoxValor2;
        private ComboBox comboBoxOpera;
        private TextBox textBoxResultado;
        private Label label2;
        private Button button1;
        private Label labelErro;
        private Button button2;
    }
}
