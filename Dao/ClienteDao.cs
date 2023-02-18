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
    public class ClienteDao
    {

        private MySqlConnection conexao;

        public ClienteDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente

        //Metodo Cadastrar Cliente

        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"insert into tb_clientes ( nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado) ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
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
                executacmd.Parameters.AddWithValue("@estado", obj.Uf);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                
            }
        }
        #endregion

        #region AlterarCliente
        //Metodo Alterar Cliente

        public void alterarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado where id=@id";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
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
                executacmd.Parameters.AddWithValue("@estado", obj.Uf);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);


            }
        }

        #endregion

        #region ExcluirCliente
        //Metodo Excluir Cliente

        public void excluirCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"delete from tb_clientes where id = @id ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
               
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }

        #endregion

        #region ListarClientes


        //Metodo Listar Cliente

        public DataTable listarClientes()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL

                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes";

                //2 passo - Organizar ocomando sql e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region BuscarClientePorNome
        //Metodo Buscar Cliente por Nome

        public DataTable buscarClientePorNome(string nome)
        {
            try
            {
                

                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome = @nome";

                

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region ListarClientePorNome
        //Metodo Buscar Cliente por Nome

        public DataTable listarClientePorNome(string nome)
        {
            try
            {


                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Retornar Cliente Por Cpf

        public Cliente retornarClientePorCpf(string cpf)
        {
            try
            {
                Cliente obj = new Cliente();
                string sql = @"select * from tb_clientes where cpf = @cpf";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    obj.Id = rs.GetInt32("id");
                    obj.Nome = rs.GetString("nome");

                    conexao.Close();
                    return obj;

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");

                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }


        #endregion
    }
}
