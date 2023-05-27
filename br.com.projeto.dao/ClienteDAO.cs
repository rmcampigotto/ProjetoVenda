using MySql.Data.MySqlClient;
using ProjetoControleVendas.br.com.projeto.connection;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.dao
{
    class ClienteDAO
    {

        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void CadastrarCliente(Client obj)
        {
            try
            {
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                               values (@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Name);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("ACONTECEU O ERRO: " + erro);
            }

            

        }
        #endregion

        #region AlterarCliente

        public void AlterarCliente(Client obj)
        {
            try
            {
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco
                ,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                 where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Name);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("CLIENTE ALTERADO COM SUCESSO!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("ACONTECEU O ERRO: " + erro);
            }



        }

        #endregion

        #region ExcluirCliente

        public void ExcluirCliente(Client obj)
        {
            try
            {
                string sql = @"delete from tb_clientes where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("CLIENTE EXCLUIDO COM SUCESSO!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("ACONTECEU O ERRO: " + erro);
            }



        }

        #endregion

        #region ListarCliente
        public DataTable listarClientes()
        {
            try
            {
                // 1 PASSO = Criar DataTable e comando SQL
                DataTable tabelaClientes = new DataTable();
                string sql = "SELECT * FROM tb_clientes";

                //2 PASSO = Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 PASSO = Criar MySqlDataAdapter e preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaClientes);
                return tabelaClientes;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Unabke to show data" + erro);
                return null;
            }
        }
        #endregion

        #region BuscarClienteNome

        public DataTable BuscarClienteNome(string nome)
        {
            try
            {
                // 1 PASSO = Criar DataTable e comando SQL
                DataTable tabelaClientes = new DataTable();
                string sql = "SELECT * FROM tb_clientes where nome = @nome";

                //2 PASSO = Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 PASSO = Criar MySqlDataAdapter e preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaClientes);
                return tabelaClientes;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Unabke to show data" + erro);
                return null;
            }
        }

        #endregion

        #region ListarClienteNome

        public DataTable ListarClienteNome(string nome)
        {
            try
            {
                // 1 PASSO = Criar DataTable e comando SQL
                DataTable tabelaClientes = new DataTable();
                string sql = "SELECT * FROM tb_clientes where nome like @nome";

                //2 PASSO = Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 PASSO = Criar MySqlDataAdapter e preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaClientes);
                return tabelaClientes;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Unabke to show data" + erro);
                return null;
            }
        }

        #endregion

    }
}
