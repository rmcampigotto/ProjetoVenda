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
    class FuncionarioDAO
    {

        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFuncionario

        public void CadastrarFuncionario(Funcionario obj) 
        {
            try
            {
                string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,
                             endereco,numero,complemento,bairro,cidade,estado) values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,
                             @endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Name);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_Acesso);
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

                MessageBox.Show("FUNCIONÁRIO CADASTRADO COM SUCESSO!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ACONTECEU O ERRO: " + erro);
            }
        }

        #endregion

        #region ListarFuncionario
        public DataTable listarFuncionario()
        {
            try
            {
                // 1 PASSO = Criar DataTable e comando SQL
                DataTable tabelaFuncionarios = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios";

                //2 PASSO = Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();   

                //3 PASSO = Criar MySqlDataAdapter e preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionarios);
                return tabelaFuncionarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Unable to show data" + erro);
                return null;
            }
        }
        #endregion

        #region AlterarFuncionario

        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,
                celular=@celular,cep=@cep,endereco=@endereco,
                numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                where id=@codigo";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Name);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_Acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@codigo", obj.Codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("FUNCIONARIO ALTERADO COM SUCESSO!");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("ACONTECEU O ERRO: " + erro);
            }



        }

        #endregion

        #region ExcluirFuncionario

        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id=@id";

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

        #region BuscarFuncionarioNome
        public DataTable BuscarFuncionarioNome(string nome)
        {
            try
            {
                // 1 PASSO = Criar DataTable e comando SQL
                DataTable tabelaFuncionarios = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios where nome = @nome";

                //2 PASSO = Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 PASSO = Criar MySqlDataAdapter e preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionarios);
                return tabelaFuncionarios;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Unabke to show data" + erro);
                return null;
            }
        }
        #endregion

        #region ListarFuncionarioNome

        public DataTable ListarFuncionarioNome(string nome)
        {
            try
            {
                // 1 PASSO = Criar DataTable e comando SQL
                DataTable tabelaFuncionarios = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios where nome like @nome";

                //2 PASSO = Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 PASSO = Criar MySqlDataAdapter e preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionarios);
                return tabelaFuncionarios;

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
