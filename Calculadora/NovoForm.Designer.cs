namespace Calculadora
{
    partial class NovoForm
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
            comboBoxCalculos = new ComboBox();
            comboBoxFormas = new ComboBox();
            label1 = new Label();
            textBoxBase = new TextBox();
            textBoxAltura = new TextBox();
            labelBase = new Label();
            labelAltura = new Label();
            labelErro = new Label();
            buttonCalcular = new Button();
            labelResultado = new Label();
            labelComprimento = new Label();
            textBoxComprimento = new TextBox();
            buttonOutraCalculadora = new Button();
            SuspendLayout();
            // 
            // comboBoxCalculos
            // 
            comboBoxCalculos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCalculos.FormattingEnabled = true;
            comboBoxCalculos.Items.AddRange(new object[] { "Área", "Perímetro", "Volume" });
            comboBoxCalculos.Location = new Point(37, 210);
            comboBoxCalculos.Name = "comboBoxCalculos";
            comboBoxCalculos.Size = new Size(121, 25);
            comboBoxCalculos.TabIndex = 0;
            comboBoxCalculos.Text = "Cálculos";
            comboBoxCalculos.SelectedIndexChanged += comboBoxCalculos_SelectedIndexChanged;
            // 
            // comboBoxFormas
            // 
            comboBoxFormas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxFormas.FormattingEnabled = true;
            comboBoxFormas.Items.AddRange(new object[] { "Quadrado", "Retângulo" });
            comboBoxFormas.Location = new Point(27, 119);
            comboBoxFormas.Name = "comboBoxFormas";
            comboBoxFormas.Size = new Size(155, 25);
            comboBoxFormas.TabIndex = 1;
            comboBoxFormas.Text = "Formas Geométricas";
            comboBoxFormas.SelectedIndexChanged += comboBoxFormas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-47, 9);
            label1.Name = "label1";
            label1.Size = new Size(553, 64);
            label1.TabIndex = 2;
            label1.Text = "                                            Calculadora de \r\n                                     Área, Perímetro, Volume\r\n";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(48, 316);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(61, 23);
            textBoxBase.TabIndex = 3;
            textBoxBase.Visible = false;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(154, 316);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(70, 23);
            textBoxAltura.TabIndex = 4;
            textBoxAltura.Visible = false;
            // 
            // labelBase
            // 
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBase.Location = new Point(57, 275);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(42, 20);
            labelBase.TabIndex = 5;
            labelBase.Text = "Base";
            labelBase.Visible = false;
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAltura.Location = new Point(162, 275);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(53, 20);
            labelAltura.TabIndex = 6;
            labelAltura.Text = "Altura";
            labelAltura.Visible = false;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(111, 378);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(162, 374);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(412, 319);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 9;
            // 
            // labelComprimento
            // 
            labelComprimento.AutoSize = true;
            labelComprimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComprimento.Location = new Point(272, 275);
            labelComprimento.Name = "labelComprimento";
            labelComprimento.Size = new Size(106, 20);
            labelComprimento.TabIndex = 10;
            labelComprimento.Text = "Comprimento";
            labelComprimento.Visible = false;
            // 
            // textBoxComprimento
            // 
            textBoxComprimento.Location = new Point(272, 316);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(106, 23);
            textBoxComprimento.TabIndex = 11;
            textBoxComprimento.Visible = false;
            // 
            // buttonOutraCalculadora
            // 
            buttonOutraCalculadora.Location = new Point(524, 415);
            buttonOutraCalculadora.Name = "buttonOutraCalculadora";
            buttonOutraCalculadora.Size = new Size(112, 23);
            buttonOutraCalculadora.TabIndex = 12;
            buttonOutraCalculadora.Text = "Outra Calculadora";
            buttonOutraCalculadora.UseVisualStyleBackColor = true;
            buttonOutraCalculadora.Click += buttonOutraCalculadora_Click;
            // 
            // NovoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(buttonOutraCalculadora);
            Controls.Add(textBoxComprimento);
            Controls.Add(labelComprimento);
            Controls.Add(labelResultado);
            Controls.Add(buttonCalcular);
            Controls.Add(labelErro);
            Controls.Add(labelAltura);
            Controls.Add(labelBase);
            Controls.Add(textBoxAltura);
            Controls.Add(textBoxBase);
            Controls.Add(label1);
            Controls.Add(comboBoxFormas);
            Controls.Add(comboBoxCalculos);
            Name = "NovoForm";
            Text = "NovoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCalculos;
        private ComboBox comboBoxFormas;
        private Label label1;
        private TextBox textBoxBase;
        private TextBox textBoxAltura;
        private Label labelBase;
        private Label labelAltura;
        private Label labelErro;
        private Button buttonCalcular;
        private Label labelResultado;
        private Label labelComprimento;
        private TextBox textBoxComprimento;
        private Button buttonOutraCalculadora;
    }
}