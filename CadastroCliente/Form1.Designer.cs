namespace CadastroCliente
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
            label1 = new Label();
            label2 = new Label();
            textBoxNome = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            maskedTextBoxDataNasc = new MaskedTextBox();
            label4 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewClientes = new DataGridView();
            labelErro = new Label();
            labelAviso = new Label();
            buttonCadastrar = new Button();
            label19 = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            label18 = new Label();
            comboBoxEstado = new ComboBox();
            label17 = new Label();
            textBoxMunicipio = new TextBox();
            label16 = new Label();
            textBoxBairro = new TextBox();
            label15 = new Label();
            textBoxComple = new TextBox();
            label14 = new Label();
            textBoxNumeroCs = new TextBox();
            label13 = new Label();
            textBoxLogradouro = new TextBox();
            label12 = new Label();
            label11 = new Label();
            radioButtonPJ = new RadioButton();
            radioButtonPF = new RadioButton();
            label10 = new Label();
            checkBoxEstrangeiro = new CheckBox();
            label9 = new Label();
            comboBoxEtnia = new ComboBox();
            label8 = new Label();
            textBoxNomeSocial = new TextBox();
            label7 = new Label();
            comboBoxGenero = new ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 19);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastre-se";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome *";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(31, 100);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(138, 23);
            textBoxNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 136);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 3;
            label3.Text = "Data de Nascimento *";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(31, 259);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(138, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // maskedTextBoxDataNasc
            // 
            maskedTextBoxDataNasc.Location = new Point(31, 154);
            maskedTextBoxDataNasc.Mask = "00/00/0000";
            maskedTextBoxDataNasc.Name = "maskedTextBoxDataNasc";
            maskedTextBoxDataNasc.Size = new Size(67, 23);
            maskedTextBoxDataNasc.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 188);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone *";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(31, 206);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(100, 23);
            maskedTextBoxTelefone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 241);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Email *";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewClientes);
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(labelAviso);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(maskedTextBoxCep);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(comboBoxEstado);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(textBoxMunicipio);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textBoxBairro);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(textBoxComple);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBoxNumeroCs);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBoxLogradouro);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(radioButtonPJ);
            groupBox1.Controls.Add(radioButtonPF);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(checkBoxEstrangeiro);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBoxEtnia);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxNomeSocial);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxGenero);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(maskedTextBoxTelefone);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBoxDataNasc);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(6, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1181, 631);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(670, 100);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(438, 369);
            dataGridViewClientes.TabIndex = 3;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(278, 476);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 38;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAviso.Location = new Point(449, 572);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(0, 15);
            labelAviso.TabIndex = 37;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(400, 514);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(98, 34);
            buttonCadastrar.TabIndex = 36;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.Location = new Point(25, 610);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 35;
            label19.Text = "* Obrigatório";
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(385, 419);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(64, 23);
            maskedTextBoxCep.TabIndex = 34;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(385, 401);
            label18.Name = "label18";
            label18.Size = new Size(35, 15);
            label18.TabIndex = 33;
            label18.Text = "CEP *";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            comboBoxEstado.Location = new Point(385, 366);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(138, 23);
            comboBoxEstado.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(385, 348);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 31;
            label17.Text = "Estado * ";
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(385, 313);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(138, 23);
            textBoxMunicipio.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(385, 295);
            label16.Name = "label16";
            label16.Size = new Size(72, 15);
            label16.TabIndex = 29;
            label16.Text = "Município * ";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(385, 259);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(138, 23);
            textBoxBairro.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(385, 241);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 27;
            label15.Text = "Bairro *";
            // 
            // textBoxComple
            // 
            textBoxComple.Location = new Point(385, 206);
            textBoxComple.Name = "textBoxComple";
            textBoxComple.Size = new Size(138, 23);
            textBoxComple.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(385, 188);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 25;
            label14.Text = "Complemento";
            // 
            // textBoxNumeroCs
            // 
            textBoxNumeroCs.Location = new Point(385, 154);
            textBoxNumeroCs.Name = "textBoxNumeroCs";
            textBoxNumeroCs.Size = new Size(138, 23);
            textBoxNumeroCs.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(385, 136);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 23;
            label13.Text = "Número * ";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(385, 100);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(138, 23);
            textBoxLogradouro.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(385, 82);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 21;
            label12.Text = "Logradouro *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(403, 42);
            label11.Name = "label11";
            label11.Size = new Size(95, 25);
            label11.TabIndex = 20;
            label11.Text = "Endereço";
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonPJ.Location = new Point(31, 554);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(107, 19);
            radioButtonPJ.TabIndex = 19;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "Pessoa Jurídica\r\n";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonPF.Location = new Point(31, 529);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(94, 19);
            radioButtonPF.TabIndex = 18;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "Pessoa Física";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(31, 511);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 17;
            label10.Text = "Tipo de Cliente *";
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEstrangeiro.Location = new Point(31, 472);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(47, 19);
            checkBoxEstrangeiro.TabIndex = 16;
            checkBoxEstrangeiro.Text = "Sim";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 454);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 15;
            label9.Text = "Estrangeiro *";
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Negro", "Pardo", "Indígena", "Amarelo", "Outro" });
            comboBoxEtnia.Location = new Point(31, 419);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(138, 23);
            comboBoxEtnia.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 401);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 13;
            label8.Text = "Etnia *";
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(31, 366);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(138, 23);
            textBoxNomeSocial.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 348);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 11;
            label7.Text = "Nome Social";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Não Binário", "Outro" });
            comboBoxGenero.Location = new Point(31, 313);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(138, 23);
            comboBoxGenero.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 295);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Gênero *";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 631);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxEmail;
        private MaskedTextBox maskedTextBoxDataNasc;
        private Label label4;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBoxNomeSocial;
        private Label label7;
        private ComboBox comboBoxGenero;
        private Label label6;
        private Label label9;
        private ComboBox comboBoxEtnia;
        private Label label8;
        private RadioButton radioButtonPJ;
        private RadioButton radioButtonPF;
        private Label label10;
        private CheckBox checkBoxEstrangeiro;
        private Label label12;
        private Label label11;
        private Label label16;
        private TextBox textBoxBairro;
        private Label label15;
        private TextBox textBoxComple;
        private Label label14;
        private TextBox textBoxNumeroCs;
        private Label label13;
        private TextBox textBoxLogradouro;
        private ComboBox comboBoxEstado;
        private Label label17;
        private TextBox textBoxMunicipio;
        private MaskedTextBox maskedTextBoxCep;
        private Label label18;
        private Button buttonCadastrar;
        private Label label19;
        private Label labelErro;
        private Label labelAviso;
        private DataGridView dataGridViewClientes;
    }
}
