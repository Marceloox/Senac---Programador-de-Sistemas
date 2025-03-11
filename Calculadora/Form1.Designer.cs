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
            label4.Size = new Size(109, 32);
            label4.TabIndex = 5;
            label4.Text = "Cálculos";
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
            buttonDiv.Location = new Point(193, 271);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(25, 23);
            buttonDiv.TabIndex = 10;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
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
        private Label label2;
        private Label labelResultado;
        private TextBox textBox1;
        private TextBox Numero2;
        private Label label4;
        private Button buttonSoma;
        private TextBox Numero1;
        private Button buttonMult;
        private Button buttonSub;
        private Button buttonDiv;
    }
}
