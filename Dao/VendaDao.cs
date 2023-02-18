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
    public class VendaDao
    {
        private MySqlConnection conexao;

        public VendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Venda

        public void cadastrarVenda(Venda obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"insert into tb_vendas ( cliente_id, data_venda, total_venda, observacoes) values (@cliente_id, @data_venda, @total_venda, @obs) ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.Cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.Data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.Total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.Obs);

                //3 passo - Abrir a conexão e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Fechar a Conexão com banco de dados
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Retornar Id Ultima Venda

         public int retornarIdUltimaVenda()
         {
            try
            {
                int idvenda = 0;
                String sql = @"select max(id) id from tb_vendas";
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader rs = executacmdsql.ExecuteReader();

                if (rs.Read())
                {
                    Venda obj = new Venda();
                    obj.Id = rs.GetInt32("id");
                    idvenda = obj.Id;
                }

                conexao.Close();
                return idvenda;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao retornar: " + erro);
                conexao.Close();
                return 0;
            }
         }

        #endregion

        #region Exibir Historico de Venda

        public DataTable listarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT   v.id as 'Código',
		                                v.data_venda as 'Data Venda',
                                        c.nome as 'Cliente',
                                        v.total_venda as 'Total',
                                        v.observacoes as 'Obs'

                              FROM tb_vendas as v INNER JOIN tb_clientes as c on (v.cliente_id = c.id)

                              WHERE v.data_venda between @datainicio and @datafim";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@datainicio", datainicio);
                executacmdsql.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Listar Todas as Vendas

        public DataTable listarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT   v.id as 'Código',
		                                v.data_venda as 'Data Venda',
                                        c.nome as 'Cliente',
                                        v.total_venda as 'Total',
                                        v.observacoes as 'Obs'

                              FROM tb_vendas as v INNER JOIN tb_clientes as c on (v.cliente_id = c.id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                conexao.Close();

                return tabelaHistorico;

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
