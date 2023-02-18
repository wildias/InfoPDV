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
    public class ProdutoDao
    {
        private MySqlConnection conexao;

        public ProdutoDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Produto

        //Metodo Cadastrar Cliente

        public void CadastrarProduto(Produto obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"insert into tb_produtos ( descricao, preco, qtd_estoque, for_id) values (@descricao, @preco, @qtd_estoque, @for_id) ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.Estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.For_id);
          
                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }
        #endregion

        #region Alterar Produto
        //Metodo Alterar Cliente

        public void alterarProduto(Produto obj)
        {
            try
            {
                //1 passo - definir o cmd sql 

                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque, for_id=@for_id where id=@id";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.Estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.For_id);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);


            }
        }

        #endregion

        #region Excluir Produto
        //Metodo Excluir Cliente

        public void excluirProduto(Produto obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"delete from tb_produtos where id = @id ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");

                //Fechar a Conexão com banco de dados
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }

        #endregion

        #region Listar Produto


        //Metodo Listar Cliente

        public DataTable listarProduto()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL

                DataTable tabelaproduto = new DataTable();
                string sql = @"select 	p.id as 'Código',
		                                p.descricao as 'Descrição',
                                        p.preco as 'Preço',
                                        p.qtd_estoque as 'Qtd Estoque',
                                        f.nome as 'Fornecedor' from tb_produtos as p
                                        join tb_fornecedores as f on (p.for_id = f.id);";

                //2 passo - Organizar ocomando sql e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelaproduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Buscar Produto Por Nome
        //Metodo Buscar Cliente por Nome

        public DataTable buscarProdutoPorNome(string descricao)
        {
            try
            {


                DataTable tabelaproduto = new DataTable();
                string sql = "select * from tb_produtos where descricao = @descricao";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelaproduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Listar Produto Por Nome
        //Metodo Buscar Cliente por Nome

        public DataTable listarProdutoPorNome(string descricao)
        {
            try
            {


                DataTable tabelaproduto = new DataTable();
                string sql = "select * from tb_produtos where descricao like @descricao";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                //Fechar a Conexão com banco de dados
                conexao.Close();

                return tabelaproduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao comando executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Retornar Produto Por Codigo

        public Produto retornarProdutoPorCodigo(int id)
        {
            try
            {
                string sql = @"select * from tb_produtos where  id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();

                    p.Id = rs.GetInt32("id");
                    p.Descricao = rs.GetString("descricao");
                    p.Preco = rs.GetDecimal("preco");

                    conexao.Close();

                    return p;

                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");

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

        #region Baixar Estoque

        public void baixarEstoque(int idproduto, int qtdestoque)
        {
            try
            {

                //1 passo - definir o cmd sql 

                string sql = @"update tb_produtos set qtd_estoque=@qtd_estoque where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                executacmd.Parameters.AddWithValue("@qtd_estoque", qtdestoque);
                executacmd.Parameters.AddWithValue("@id", idproduto);
               

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Fechar a Conexão com banco de dados
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }

        #endregion

        #region Retornar Estoque Atual

        public int retornarEstoqueAtual(int idproduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where  id = @id";
                int qtd_estoque = 0;

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {

                    qtd_estoque = rs.GetInt32("qtd_estoque");
                 
                    conexao.Close();


                }
                    return qtd_estoque;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

                return 0;
            }
        }

        #endregion
    }
}
