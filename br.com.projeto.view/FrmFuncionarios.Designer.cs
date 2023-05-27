
namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmFuncionarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFuncionarios = new System.Windows.Forms.TabControl();
            this.tabPageDadosPessoais = new System.Windows.Forms.TabPage();
            this.btnCEP = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbAcesso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.btnLimparTabela = new System.Windows.Forms.Button();
            this.tabelaFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabFuncionarios.SuspendLayout();
            this.tabPageDadosPessoais.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionarios";
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.tabPageDadosPessoais);
            this.tabFuncionarios.Controls.Add(this.tabPageConsulta);
            this.tabFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFuncionarios.Location = new System.Drawing.Point(8, 114);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.SelectedIndex = 0;
            this.tabFuncionarios.Size = new System.Drawing.Size(788, 319);
            this.tabFuncionarios.TabIndex = 2;
            // 
            // tabPageDadosPessoais
            // 
            this.tabPageDadosPessoais.Controls.Add(this.btnCEP);
            this.tabPageDadosPessoais.Controls.Add(this.btnExcluir);
            this.tabPageDadosPessoais.Controls.Add(this.btnEditar);
            this.tabPageDadosPessoais.Controls.Add(this.btnSalvar);
            this.tabPageDadosPessoais.Controls.Add(this.btnNovo);
            this.tabPageDadosPessoais.Controls.Add(this.cbAcesso);
            this.tabPageDadosPessoais.Controls.Add(this.label4);
            this.tabPageDadosPessoais.Controls.Add(this.cbCargo);
            this.tabPageDadosPessoais.Controls.Add(this.label3);
            this.tabPageDadosPessoais.Controls.Add(this.cbUf);
            this.tabPageDadosPessoais.Controls.Add(this.lblUf);
            this.tabPageDadosPessoais.Controls.Add(this.txtCidade);
            this.tabPageDadosPessoais.Controls.Add(this.lblCidade);
            this.tabPageDadosPessoais.Controls.Add(this.txtBairro);
            this.tabPageDadosPessoais.Controls.Add(this.lblBairro);
            this.tabPageDadosPessoais.Controls.Add(this.txtComplemento);
            this.tabPageDadosPessoais.Controls.Add(this.lblComplemento);
            this.tabPageDadosPessoais.Controls.Add(this.txtNumero);
            this.tabPageDadosPessoais.Controls.Add(this.lblNumero);
            this.tabPageDadosPessoais.Controls.Add(this.txtEndereco);
            this.tabPageDadosPessoais.Controls.Add(this.lblEndereco);
            this.tabPageDadosPessoais.Controls.Add(this.txtCep);
            this.tabPageDadosPessoais.Controls.Add(this.lblCep);
            this.tabPageDadosPessoais.Controls.Add(this.txtCelular);
            this.tabPageDadosPessoais.Controls.Add(this.lblCelular);
            this.tabPageDadosPessoais.Controls.Add(this.txtTelefone);
            this.tabPageDadosPessoais.Controls.Add(this.lblTelefone);
            this.tabPageDadosPessoais.Controls.Add(this.txtCPF);
            this.tabPageDadosPessoais.Controls.Add(this.lblCpf);
            this.tabPageDadosPessoais.Controls.Add(this.txtRG);
            this.tabPageDadosPessoais.Controls.Add(this.lblRg);
            this.tabPageDadosPessoais.Controls.Add(this.txtSenha);
            this.tabPageDadosPessoais.Controls.Add(this.label2);
            this.tabPageDadosPessoais.Controls.Add(this.txtEmail);
            this.tabPageDadosPessoais.Controls.Add(this.lblEmail);
            this.tabPageDadosPessoais.Controls.Add(this.txtNome);
            this.tabPageDadosPessoais.Controls.Add(this.txtCodigo);
            this.tabPageDadosPessoais.Controls.Add(this.lblNome);
            this.tabPageDadosPessoais.Controls.Add(this.lblCodigo);
            this.tabPageDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosPessoais.Name = "tabPageDadosPessoais";
            this.tabPageDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosPessoais.Size = new System.Drawing.Size(780, 293);
            this.tabPageDadosPessoais.TabIndex = 0;
            this.tabPageDadosPessoais.Text = "Dados Pessoais";
            this.tabPageDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnCEP
            // 
            this.btnCEP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCEP.ForeColor = System.Drawing.Color.White;
            this.btnCEP.Location = new System.Drawing.Point(286, 118);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(75, 23);
            this.btnCEP.TabIndex = 33;
            this.btnCEP.Text = "PESQUISAR";
            this.btnCEP.UseVisualStyleBackColor = false;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(485, 253);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 32);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(276, 253);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 32);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "ALTERAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(380, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 32);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(172, 253);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 32);
            this.btnNovo.TabIndex = 29;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbAcesso
            // 
            this.cbAcesso.FormattingEnabled = true;
            this.cbAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cbAcesso.Location = new System.Drawing.Point(580, 91);
            this.cbAcesso.Name = "cbAcesso";
            this.cbAcesso.Size = new System.Drawing.Size(150, 24);
            this.cbAcesso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(519, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "ACESSO:";
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Estagiario"});
            this.cbCargo.Location = new System.Drawing.Point(357, 91);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(150, 24);
            this.cbCargo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(294, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "CARGO: ";
            // 
            // cbUf
            // 
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
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
            this.cbUf.Location = new System.Drawing.Point(77, 145);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(150, 24);
            this.cbUf.TabIndex = 8;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUf.Location = new System.Drawing.Point(41, 148);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 16);
            this.lblUf.TabIndex = 27;
            this.lblUf.Text = "UF: ";
            // 
            // txtCidade
            // 
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCidade.Location = new System.Drawing.Point(300, 145);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(150, 21);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCidade.Location = new System.Drawing.Point(239, 148);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 16);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "CIDADE: ";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(513, 145);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(150, 21);
            this.txtBairro.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBairro.Location = new System.Drawing.Point(453, 148);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(54, 16);
            this.lblBairro.TabIndex = 22;
            this.lblBairro.Text = "BAIRRO: ";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(561, 175);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(103, 21);
            this.txtComplemento.TabIndex = 13;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblComplemento.Location = new System.Drawing.Point(453, 178);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(102, 16);
            this.lblComplemento.TabIndex = 20;
            this.lblComplemento.Text = "COMPLEMENTO: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(300, 175);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 21);
            this.txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumero.Location = new System.Drawing.Point(230, 178);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(64, 16);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "NUMERO: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(77, 172);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(150, 21);
            this.txtEndereco.TabIndex = 11;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEndereco.Location = new System.Drawing.Point(7, 175);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(74, 16);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "ENDEREÇO: ";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(77, 118);
            this.txtCep.Mask = "#####-###";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(203, 21);
            this.txtCep.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCep.Location = new System.Drawing.Point(32, 121);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(36, 16);
            this.lblCep.TabIndex = 14;
            this.lblCep.Text = "CEP: ";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(580, 64);
            this.txtCelular.Mask = "(99) 0 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(150, 21);
            this.txtCelular.TabIndex = 6;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCelular.Location = new System.Drawing.Point(513, 67);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(61, 16);
            this.lblCelular.TabIndex = 12;
            this.lblCelular.Text = "CELULAR: ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(357, 64);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(150, 21);
            this.txtTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTelefone.Location = new System.Drawing.Point(286, 67);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 16);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "TELEFONE: ";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(580, 37);
            this.txtCPF.Mask = "###.###.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(150, 21);
            this.txtCPF.TabIndex = 3;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCpf.Location = new System.Drawing.Point(539, 40);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(35, 16);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF: ";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(357, 37);
            this.txtRG.Mask = "##.###.###-#";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(150, 21);
            this.txtRG.TabIndex = 2;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRg.Location = new System.Drawing.Point(320, 40);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(31, 16);
            this.lblRg.TabIndex = 6;
            this.lblRg.Text = "RG: ";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(77, 91);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(203, 21);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "SENHA: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(22, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "EMAIL: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 21);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 21);
            this.txtCodigo.TabIndex = 30;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNome.Location = new System.Drawing.Point(22, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME: ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigo.Location = new System.Drawing.Point(7, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO: ";
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.btnLimparTabela);
            this.tabPageConsulta.Controls.Add(this.tabelaFuncionarios);
            this.tabPageConsulta.Controls.Add(this.btnPesquisar);
            this.tabPageConsulta.Controls.Add(this.txtNomeConsulta);
            this.tabPageConsulta.Controls.Add(this.lblNome2);
            this.tabPageConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulta.Size = new System.Drawing.Size(780, 293);
            this.tabPageConsulta.TabIndex = 1;
            this.tabPageConsulta.Text = "Consulta";
            this.tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // btnLimparTabela
            // 
            this.btnLimparTabela.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimparTabela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparTabela.ForeColor = System.Drawing.Color.White;
            this.btnLimparTabela.Location = new System.Drawing.Point(377, 6);
            this.btnLimparTabela.Name = "btnLimparTabela";
            this.btnLimparTabela.Size = new System.Drawing.Size(98, 23);
            this.btnLimparTabela.TabIndex = 32;
            this.btnLimparTabela.Text = "LIMPAR";
            this.btnLimparTabela.UseVisualStyleBackColor = false;
            this.btnLimparTabela.Click += new System.EventHandler(this.btnLimparTabela_Click);
            // 
            // tabelaFuncionarios
            // 
            this.tabelaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFuncionarios.Location = new System.Drawing.Point(7, 33);
            this.tabelaFuncionarios.Name = "tabelaFuncionarios";
            this.tabelaFuncionarios.Size = new System.Drawing.Size(767, 252);
            this.tabelaFuncionarios.TabIndex = 31;
            this.tabelaFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaFuncionarios_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(273, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 24);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(64, 6);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(203, 21);
            this.txtNomeConsulta.TabIndex = 5;
            this.txtNomeConsulta.TextChanged += new System.EventHandler(this.txtNomeConsulta_TextChanged);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNome2.Location = new System.Drawing.Point(9, 9);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(49, 16);
            this.lblNome2.TabIndex = 4;
            this.lblNome2.Text = "NOME: ";
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.tabFuncionarios);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFuncionarios.ResumeLayout(false);
            this.tabPageDadosPessoais.ResumeLayout(false);
            this.tabPageDadosPessoais.PerformLayout();
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabFuncionarios;
        private System.Windows.Forms.TabPage tabPageDadosPessoais;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.Button btnLimparTabela;
        private System.Windows.Forms.DataGridView tabelaFuncionarios;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAcesso;
        private System.Windows.Forms.Label label4;
    }
}