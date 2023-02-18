using MySql.Data.MySqlClient;
using Projeto_controle_de_vendas.Conexao;
using Projeto_controle_de_vendas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_controle_de_vendas.Dao
{
    public class FornecedorDao
    {
        private MySqlConnection conexao;

        public FornecedorDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Fornecedor

        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"insert into tb_fornecedores ( nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado) ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Uf);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }

        #endregion

        #region Alterar Fornecedor

        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"update tb_fornecedores set nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado where id=@id";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Uf);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);


            }
        }

        #endregion

        #region Excluir Fornecedor

        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"delete from tb_fornecedores where id = @id ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }

        #endregion

        #region Listar Fornecedor

        public DataTable listarFornecedor()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL

                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores";

                //2 passo - Organizar ocomando sql e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelafornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Buscar Fornecedor Por Nome

        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {


                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelafornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Listar Fornecedor Por Nome

        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {


                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelafornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion
    }
}
