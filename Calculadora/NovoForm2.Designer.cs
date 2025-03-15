namespace Calculadora
{
    partial class NovoForm2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxForma = new ComboBox();
            groupBoxCalculo = new GroupBox();
            label7 = new Label();
            textBoxResultado = new TextBox();
            label6 = new Label();
            textBoxRaio = new TextBox();
            buttonCalcular = new Button();
            radioButtonVolume = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonPeri = new RadioButton();
            radioButtonDiametro = new RadioButton();
            labelErro = new Label();
            groupBoxCalculo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 22);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "Cálculos com Círculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 152);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Diâmetro = 2 * r";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 196);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Perímetro = 2 * Pi * r";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 238);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Área = Pi * r^2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 276);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 4;
            label5.Text = "Volume = 4 / 3 * Pi * r ^3";
            // 
            // comboBoxForma
            // 
            comboBoxForma.FormattingEnabled = true;
            comboBoxForma.Items.AddRange(new object[] { "Círculo" });
            comboBoxForma.Location = new Point(27, 55);
            comboBoxForma.Name = "comboBoxForma";
            comboBoxForma.Size = new Size(121, 23);
            comboBoxForma.TabIndex = 5;
            // 
            // groupBoxCalculo
            // 
            groupBoxCalculo.Controls.Add(label7);
            groupBoxCalculo.Controls.Add(textBoxResultado);
            groupBoxCalculo.Controls.Add(label6);
            groupBoxCalculo.Controls.Add(textBoxRaio);
            groupBoxCalculo.Controls.Add(buttonCalcular);
            groupBoxCalculo.Controls.Add(radioButtonVolume);
            groupBoxCalculo.Controls.Add(radioButtonArea);
            groupBoxCalculo.Controls.Add(radioButtonPeri);
            groupBoxCalculo.Controls.Add(radioButtonDiametro);
            groupBoxCalculo.Location = new Point(12, 113);
            groupBoxCalculo.Name = "groupBoxCalculo";
            groupBoxCalculo.Size = new Size(452, 197);
            groupBoxCalculo.TabIndex = 6;
            groupBoxCalculo.TabStop = false;
            groupBoxCalculo.Text = "Cálculos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 86);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 7;
            label7.Text = "Resultado";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(71, 83);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(81, 23);
            textBoxResultado.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 42);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 7;
            label6.Text = "Raio";
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(71, 39);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(81, 23);
            textBoxRaio.TabIndex = 5;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(335, 39);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 4;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(193, 151);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 3;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(193, 109);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 2;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Área";
            radioButtonArea.UseVisualStyleBackColor = true;
            // 
            // radioButtonPeri
            // 
            radioButtonPeri.AutoSize = true;
            radioButtonPeri.Location = new Point(193, 67);
            radioButtonPeri.Name = "radioButtonPeri";
            radioButtonPeri.Size = new Size(77, 19);
            radioButtonPeri.TabIndex = 1;
            radioButtonPeri.TabStop = true;
            radioButtonPeri.Text = "Perímetro";
            radioButtonPeri.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiametro
            // 
            radioButtonDiametro.AutoSize = true;
            radioButtonDiametro.Location = new Point(193, 24);
            radioButtonDiametro.Name = "radioButtonDiametro";
            radioButtonDiametro.Size = new Size(74, 19);
            radioButtonDiametro.TabIndex = 0;
            radioButtonDiametro.TabStop = true;
            radioButtonDiametro.Text = "Diâmetro";
            radioButtonDiametro.UseVisualStyleBackColor = true;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(235, 356);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 7;
            // 
            // NovoForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 450);
            Controls.Add(labelErro);
            Controls.Add(groupBoxCalculo);
            Controls.Add(comboBoxForma);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NovoForm2";
            Text = "NovoForm2";
            groupBoxCalculo.ResumeLayout(false);
            groupBoxCalculo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxForma;
        private GroupBox groupBoxCalculo;
        private RadioButton radioButtonVolume;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonPeri;
        private RadioButton radioButtonDiametro;
        private Label label7;
        private TextBox textBoxResultado;
        private Label label6;
        private TextBox textBoxRaio;
        private Button buttonCalcular;
        private Label labelErro;
    }
}