using MySql.Data.MySqlClient;
using Projeto_controle_de_vendas.Conexao;
using Projeto_controle_de_vendas.Model;
using Projeto_controle_de_vendas.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_controle_de_vendas.Dao
{
    public class FuncionarioDao
    {
        private MySqlConnection conexao;

        public FuncionarioDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Funcionario

        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - Criar o comando sql

                string sql = "insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Acesso);
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

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Alterar Funcinário

        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado where id=@id";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Acesso);
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

                MessageBox.Show("Funcionário alterado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);


            }
        }

        #endregion

        #region Excluir Funcionário

        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"delete from tb_funcionarios where id = @id ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }

        #endregion

        #region Listar Funcionários

        public DataTable listarFuncionarios()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL

                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                //2 passo - Organizar ocomando sql e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelafuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }


        #endregion

        #region Buscar Funcionário Por Nome

        public DataTable buscarFuncionarioPorNome(string nome)
        {
            try
            {


                DataTable tabelafuncionario= new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelafuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Listar Funcionário Por Nome

        public DataTable listarFuncionarioPorNome(string nome)
        {
            try
            {


                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelafuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Efetuar Login

        public bool efetuarLogin(string login, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios
                                        where nome = @nome and senha = @senha";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", login);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {

                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                    MessageBox.Show("Seja bem vindo(a) ao sistema, " + nome);
                    
                    FrmMenu telamenu = new FrmMenu();

                    telamenu.txtUser.Text = nome;

                    if (nivel.Equals("Administrador"))
                    {
                        telamenu.Show();
                    }
                    else if (nivel.Equals("Vendedor"))
                    {
                        telamenu.menuProduto.Visible = false;
                        telamenu.menuCliente.Visible = false;
                        telamenu.menuFornecedor.Visible = false;
                        telamenu.menuFuncionario.Visible = false;

                        telamenu.Show();
                    }
                    

                    return true;
                }
                else
                {
                    MessageBox.Show("Login ou senha inválido!");
                    return false;
                }


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }
        }

        #endregion

    }
}
