﻿namespace Cadastro_de_Alunos
{
    partial class Cadastro_de_Funcionários
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Funcionários));
			this.cbxUF = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtLogradouro = new System.Windows.Forms.TextBox();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mskCpf = new System.Windows.Forms.MaskedTextBox();
			this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxSexo = new System.Windows.Forms.ComboBox();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbFotoFunc = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtCEP = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtDDD2 = new System.Windows.Forms.TextBox();
			this.txtTelefone2 = new System.Windows.Forms.TextBox();
			this.txtDDD1 = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rbGerente = new System.Windows.Forms.RadioButton();
			this.rbAtendente = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnSelecFoto = new System.Windows.Forms.Button();
			this.txtFotoLocal = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.ckbMostrarSenha = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFotoFunc)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbxUF
			// 
			this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxUF.FormattingEnabled = true;
			this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA  ",
            "CE  ",
            "DF ",
            "ES ",
            "GO",
            "MA ",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
			this.cbxUF.Location = new System.Drawing.Point(133, 44);
			this.cbxUF.MaxLength = 2;
			this.cbxUF.Name = "cbxUF";
			this.cbxUF.Size = new System.Drawing.Size(47, 21);
			this.cbxUF.TabIndex = 30;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(99, 48);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 13);
			this.label15.TabIndex = 119;
			this.label15.Text = "*UF:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(193, 21);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 13);
			this.label14.TabIndex = 118;
			this.label14.Text = "*Logradouro:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(199, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(74, 13);
			this.label13.TabIndex = 117;
			this.label13.Text = "Complemento:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(214, 75);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(55, 13);
			this.label12.TabIndex = 116;
			this.label12.Text = "*Cidade:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(22, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(30, 13);
			this.label11.TabIndex = 115;
			this.label11.Text = "*Nº:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 13);
			this.label10.TabIndex = 114;
			this.label10.Text = "*Bairro:";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(54, 44);
			this.txtNumero.MaxLength = 20;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(36, 20);
			this.txtNumero.TabIndex = 27;
			this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(54, 73);
			this.txtBairro.MaxLength = 150;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(126, 20);
			this.txtBairro.TabIndex = 35;
			// 
			// txtLogradouro
			// 
			this.txtLogradouro.Location = new System.Drawing.Point(274, 17);
			this.txtLogradouro.MaxLength = 150;
			this.txtLogradouro.Name = "txtLogradouro";
			this.txtLogradouro.Size = new System.Drawing.Size(158, 20);
			this.txtLogradouro.TabIndex = 25;
			// 
			// txtComplemento
			// 
			this.txtComplemento.Location = new System.Drawing.Point(274, 43);
			this.txtComplemento.MaxLength = 150;
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(158, 20);
			this.txtComplemento.TabIndex = 33;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 106;
			this.label2.Text = "*CPF:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(49, 19);
			this.txtNome.MaxLength = 150;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(206, 20);
			this.txtNome.TabIndex = 0;
			this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mskCpf);
			this.groupBox1.Controls.Add(this.mskDataNascimento);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbxSexo);
			this.groupBox1.Controls.Add(this.txtRG);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(473, 111);
			this.groupBox1.TabIndex = 107;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Pessoais:";
			// 
			// mskCpf
			// 
			this.mskCpf.Location = new System.Drawing.Point(49, 45);
			this.mskCpf.Mask = "000,000,000-00";
			this.mskCpf.Name = "mskCpf";
			this.mskCpf.Size = new System.Drawing.Size(82, 20);
			this.mskCpf.TabIndex = 15;
			this.mskCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCpf_KeyPress);
			// 
			// mskDataNascimento
			// 
			this.mskDataNascimento.Location = new System.Drawing.Point(135, 77);
			this.mskDataNascimento.Mask = "00/00/0000";
			this.mskDataNascimento.Name = "mskDataNascimento";
			this.mskDataNascimento.Size = new System.Drawing.Size(64, 20);
			this.mskDataNascimento.TabIndex = 20;
			this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(137, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "*RG:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(273, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "*Gênero:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "*Data de Nascimento:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "*Nome:";
			// 
			// cbxSexo
			// 
			this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSexo.FormattingEnabled = true;
			this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
			this.cbxSexo.Location = new System.Drawing.Point(331, 18);
			this.cbxSexo.Name = "cbxSexo";
			this.cbxSexo.Size = new System.Drawing.Size(121, 21);
			this.cbxSexo.TabIndex = 12;
			// 
			// txtRG
			// 
			this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRG.Location = new System.Drawing.Point(177, 45);
			this.txtRG.MaxLength = 9;
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(78, 20);
			this.txtRG.TabIndex = 17;
			this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbFotoFunc);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(505, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(190, 179);
			this.groupBox2.TabIndex = 109;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Foto:";
			// 
			// pbFotoFunc
			// 
			this.pbFotoFunc.Location = new System.Drawing.Point(6, 21);
			this.pbFotoFunc.Name = "pbFotoFunc";
			this.pbFotoFunc.Size = new System.Drawing.Size(178, 151);
			this.pbFotoFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbFotoFunc.TabIndex = 108;
			this.pbFotoFunc.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtCEP);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtCidade);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.txtNumero);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.cbxUF);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.txtLogradouro);
			this.groupBox3.Controls.Add(this.txtBairro);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.txtComplemento);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 151);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(473, 101);
			this.groupBox3.TabIndex = 121;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Endreço:";
			// 
			// txtCEP
			// 
			this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCEP.Location = new System.Drawing.Point(54, 18);
			this.txtCEP.MaxLength = 9;
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(126, 20);
			this.txtCEP.TabIndex = 23;
			this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 13);
			this.label9.TabIndex = 29;
			this.label9.Text = "*C.E.P:";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(274, 69);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(158, 20);
			this.txtCidade.TabIndex = 38;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(203, 422);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 138;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(91, 422);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
			this.btnCadastrar.TabIndex = 137;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtDDD2);
			this.groupBox4.Controls.Add(this.txtTelefone2);
			this.groupBox4.Controls.Add(this.txtDDD1);
			this.groupBox4.Controls.Add(this.txtTelefone);
			this.groupBox4.Controls.Add(this.txtEmail);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 258);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(473, 69);
			this.groupBox4.TabIndex = 140;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Contatos:";
			// 
			// txtDDD2
			// 
			this.txtDDD2.Location = new System.Drawing.Point(269, 19);
			this.txtDDD2.MaxLength = 2;
			this.txtDDD2.Name = "txtDDD2";
			this.txtDDD2.Size = new System.Drawing.Size(30, 20);
			this.txtDDD2.TabIndex = 50;
			this.txtDDD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// txtTelefone2
			// 
			this.txtTelefone2.Location = new System.Drawing.Point(305, 19);
			this.txtTelefone2.MaxLength = 9;
			this.txtTelefone2.Name = "txtTelefone2";
			this.txtTelefone2.Size = new System.Drawing.Size(92, 20);
			this.txtTelefone2.TabIndex = 55;
			this.txtTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// txtDDD1
			// 
			this.txtDDD1.Location = new System.Drawing.Point(74, 19);
			this.txtDDD1.MaxLength = 2;
			this.txtDDD1.Name = "txtDDD1";
			this.txtDDD1.Size = new System.Drawing.Size(30, 20);
			this.txtDDD1.TabIndex = 40;
			this.txtDDD1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDD1_KeyPress);
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(110, 19);
			this.txtTelefone.MaxLength = 9;
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(92, 20);
			this.txtTelefone.TabIndex = 45;
			this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(74, 45);
			this.txtEmail.MaxLength = 100;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(128, 20);
			this.txtEmail.TabIndex = 60;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 102;
			this.label6.Text = "E-Mail:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(208, 22);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(58, 13);
			this.label17.TabIndex = 39;
			this.label17.Text = "Telefone2:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 23);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 13);
			this.label16.TabIndex = 101;
			this.label16.Text = "*Telefone:";
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(323, 422);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 23);
			this.btnVoltar.TabIndex = 141;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Green;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.SystemColors.Control;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(759, 31);
			this.panel1.TabIndex = 142;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(41, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(162, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "Cadastro de Funcionários";
			// 
			// rbGerente
			// 
			this.rbGerente.AutoSize = true;
			this.rbGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbGerente.Location = new System.Drawing.Point(22, 55);
			this.rbGerente.Name = "rbGerente";
			this.rbGerente.Size = new System.Drawing.Size(63, 17);
			this.rbGerente.TabIndex = 133;
			this.rbGerente.Text = "Gerente";
			this.rbGerente.UseVisualStyleBackColor = true;
			this.rbGerente.CheckedChanged += new System.EventHandler(this.rbGerente_CheckedChanged);
			// 
			// rbAtendente
			// 
			this.rbAtendente.AutoSize = true;
			this.rbAtendente.BackColor = System.Drawing.SystemColors.Control;
			this.rbAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAtendente.Location = new System.Drawing.Point(22, 29);
			this.rbAtendente.Name = "rbAtendente";
			this.rbAtendente.Size = new System.Drawing.Size(74, 17);
			this.rbAtendente.TabIndex = 132;
			this.rbAtendente.Text = "Atendente";
			this.rbAtendente.UseVisualStyleBackColor = false;
			this.rbAtendente.CheckedChanged += new System.EventHandler(this.rbAtendente_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.rbAtendente);
			this.groupBox5.Controls.Add(this.rbGerente);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(520, 276);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(131, 83);
			this.groupBox5.TabIndex = 134;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Perfil de Acesso:";
			// 
			// btnSelecFoto
			// 
			this.btnSelecFoto.Location = new System.Drawing.Point(511, 247);
			this.btnSelecFoto.Name = "btnSelecFoto";
			this.btnSelecFoto.Size = new System.Drawing.Size(178, 23);
			this.btnSelecFoto.TabIndex = 143;
			this.btnSelecFoto.Text = "Selecionar Foto";
			this.btnSelecFoto.UseVisualStyleBackColor = true;
			this.btnSelecFoto.Click += new System.EventHandler(this.btnSelecFoto_Click);
			// 
			// txtFotoLocal
			// 
			this.txtFotoLocal.Location = new System.Drawing.Point(511, 220);
			this.txtFotoLocal.Name = "txtFotoLocal";
			this.txtFotoLocal.ReadOnly = true;
			this.txtFotoLocal.Size = new System.Drawing.Size(178, 20);
			this.txtFotoLocal.TabIndex = 152;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(11, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 153;
			this.label8.Text = "Senha:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(217, 351);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(108, 13);
			this.label18.TabIndex = 154;
			this.label18.Text = " Confirmar Senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(64, 15);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(120, 20);
			this.txtSenha.TabIndex = 155;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// txtConfirmarSenha
			// 
			this.txtConfirmarSenha.Location = new System.Drawing.Point(319, 15);
			this.txtConfirmarSenha.Name = "txtConfirmarSenha";
			this.txtConfirmarSenha.Size = new System.Drawing.Size(120, 20);
			this.txtConfirmarSenha.TabIndex = 156;
			this.txtConfirmarSenha.UseSystemPasswordChar = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.ckbMostrarSenha);
			this.groupBox6.Controls.Add(this.txtSenha);
			this.groupBox6.Controls.Add(this.txtConfirmarSenha);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Location = new System.Drawing.Point(12, 333);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(473, 62);
			this.groupBox6.TabIndex = 157;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Definir Senha:";
			// 
			// ckbMostrarSenha
			// 
			this.ckbMostrarSenha.AutoSize = true;
			this.ckbMostrarSenha.Location = new System.Drawing.Point(64, 41);
			this.ckbMostrarSenha.Name = "ckbMostrarSenha";
			this.ckbMostrarSenha.Size = new System.Drawing.Size(95, 17);
			this.ckbMostrarSenha.TabIndex = 157;
			this.ckbMostrarSenha.Text = "Mostrar Senha";
			this.ckbMostrarSenha.UseVisualStyleBackColor = true;
			this.ckbMostrarSenha.CheckedChanged += new System.EventHandler(this.ckbMostrarSenha_CheckedChanged);
			// 
			// Cadastro_de_Funcionários
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 476);
			this.ControlBox = false;
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtFotoLocal);
			this.Controls.Add(this.btnSelecFoto);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cadastro_de_Funcionários";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.Load += new System.EventHandler(this.Cadastro_de_Funcionários_Load_1);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbFotoFunc)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.ComboBox cbxUF;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.TextBox txtLogradouro;
		private System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.PictureBox pbFotoFunc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxSexo;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtCEP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
		private System.Windows.Forms.MaskedTextBox mskDataNascimento;
		private System.Windows.Forms.MaskedTextBox mskCpf;
		private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbGerente;
        private System.Windows.Forms.RadioButton rbAtendente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDDD2;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.TextBox txtDDD1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelecFoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFotoLocal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtConfirmarSenha;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox ckbMostrarSenha;
	}
}