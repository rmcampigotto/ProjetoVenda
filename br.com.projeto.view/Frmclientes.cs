using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoControleVendas.br.com.projeto.dao;
using ProjetoControleVendas.br.com.projeto.model;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("DESEJA SALVAR O NOVO USUÁRIO?", " ", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Client obj = new Client();
                obj.Name = txtNome.Text;
                obj.Rg = txtRG.Text;
                obj.Cpf = txtCPF.Text;
                obj.Email = txtEmail.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Celular = txtCelular.Text;
                obj.Cep = txtCep.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Numero = int.Parse(txtNumero.Text);
                obj.Complemento = txtComplemento.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.Estado = cbUf.SelectedItem.ToString();

                ClienteDAO dao = new ClienteDAO();
                dao.CadastrarCliente(obj);

                tabelaCliente.DataSource = dao.listarClientes();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO CADASTRADO!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }


        private void Frmclientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DefaultCellStyle.BackColor = Color.White;
            tabelaCliente.DefaultCellStyle.ForeColor = Color.Black;
            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tabClients.SelectedTab = tabPageDadosPessoais;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("DESEJA MESMO ECLUIR ESTE USUÁRIO?", " ", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Client obj = new Client();

                obj.Codigo = int.Parse(txtCodigo.Text);

                ClienteDAO dao = new ClienteDAO();

                dao.ExcluirCliente(obj);

                tabelaCliente.DataSource = dao.listarClientes();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO EXCLUÍDO!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("DESEJA SALVAR AS ALTERAÇÕES?", " ", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Client obj = new Client();
                obj.Name = txtNome.Text;
                obj.Rg = txtRG.Text;
                obj.Cpf = txtCPF.Text;
                obj.Email = txtEmail.Text;
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

                ClienteDAO dao = new ClienteDAO();
                dao.AlterarCliente(obj);

                tabelaCliente.DataSource = dao.listarClientes();
            }
            else
            {
                MessageBox.Show("ALTERAÇÕES DESCARTADAS!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClienteNome(nome);

        }

        private void btnLimparTabela_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.listarClientes();

            txtNomeConsulta.Clear();
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.ListarClienteNome(nome);

            if (tabelaCliente.Rows.Count == 0)
            {
                tabelaCliente.DataSource = dao.listarClientes();
            }
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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
    }
}
