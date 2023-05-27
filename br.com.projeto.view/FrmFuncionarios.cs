using ProjetoControleVendas.br.com.projeto.dao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionarios.DataSource = dao.BuscarFuncionarioNome(nome);

        }

        private void btnLimparTabela_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionarios.DataSource = dao.listarFuncionario();

            txtNomeConsulta.Clear();
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("CEP NÃO ENCONTRADO, FAVOR DIGITAR MANUALMENTE!");
                txtCep.Clear();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("DESEJA SALVAR AS ALTERAÇÕES?", " ", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Funcionario obj = new Funcionario();
                obj.Name = txtNome.Text;
                obj.Rg = txtRG.Text;
                obj.Cpf = txtCPF.Text;
                obj.Email = txtEmail.Text;
                obj.Senha = txtSenha.Text;
                obj.Cargo = cbCargo.Text;
                obj.Nivel_Acesso = cbAcesso.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Celular = txtCelular.Text;
                obj.Cep = txtCep.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Numero = int.Parse(txtNumero.Text);
                obj.Complemento = txtComplemento.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.Estado = cbUf.Text;
                obj.Codigo = int.Parse(txtCodigo.Text);

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.AlterarFuncionario(obj);
                    
                tabelaFuncionarios.DataSource = dao.listarFuncionario();
            }
            else
            {
                MessageBox.Show("ALTERAÇÕES DESCARTADAS!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("DESEJA SALVAR O NOVO FUNCIONARIO?", " ", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Funcionario obj = new Funcionario();
                obj.Name = txtNome.Text;
                obj.Rg = txtRG.Text;
                obj.Cpf = txtCPF.Text;
                obj.Email = txtEmail.Text;
                obj.Senha = txtSenha.Text;
                obj.Cargo = cbCargo.SelectedItem.ToString();
                obj.Nivel_Acesso = cbAcesso.SelectedItem.ToString();
                obj.Telefone = txtTelefone.Text;
                obj.Celular = txtCelular.Text;
                obj.Cep = txtCep.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Numero = int.Parse(txtNumero.Text);
                obj.Complemento = txtComplemento.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.Estado = cbUf.SelectedItem.ToString();

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.CadastrarFuncionario(obj);

                tabelaFuncionarios.DataSource = dao.listarFuncionario();

            }
            else
            {
                MessageBox.Show("FUNCIONARIO NÃO CADASTRADO!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("DESEJA MESMO ECLUIR ESTE FUNCIONARIO?", " ", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Funcionario obj = new Funcionario();

                obj.Codigo = int.Parse(txtCodigo.Text);

                FuncionarioDAO dao = new FuncionarioDAO();

                dao.ExcluirFuncionario(obj);

                tabelaFuncionarios.DataSource = dao.listarFuncionario();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO EXCLUÍDO!");
            }
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            tabelaFuncionarios.DefaultCellStyle.BackColor = Color.White;
            tabelaFuncionarios.DefaultCellStyle.ForeColor = Color.Black;
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionarios.DataSource = dao.listarFuncionario();
        }

        private void tabelaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = tabelaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = tabelaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionarios.CurrentRow.Cells[4].Value.ToString();

            txtSenha.Text = tabelaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = tabelaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbAcesso.Text = tabelaFuncionarios.CurrentRow.Cells[7].Value.ToString();

            txtTelefone.Text = tabelaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = tabelaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbUf.Text = tabelaFuncionarios.CurrentRow.Cells[16].Value.ToString();

            tabFuncionarios.SelectedTab = tabPageDadosPessoais;
        }

        private void txtNomeConsulta_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionarios.DataSource = dao.ListarFuncionarioNome(nome);

            if (tabelaFuncionarios.Rows.Count == 0)
            {
                tabelaFuncionarios.DataSource = dao.listarFuncionario();
            }
        }
    }
}
