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
    public class ItemVendaDao
    {
        private MySqlConnection conexao;

        public ItemVendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Item Venda

        public void cadastrarItem(ItemVenda obj)
        {
            try
            {
                //1 passo - definir o cmd sql - insert into

                string sql = @"insert into tb_itensvendas ( venda_id, produto_id, qtd, subtotal) values (@venda_id, @produto_id, @qtd, @subtotal) ";

                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.Venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.Produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

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

        #region Listar todos os itens por venda

        public DataTable listarItensPorVendas(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();

                string sql = @"SELECT  i.id as 'Código',
                                       p.descricao as 'Descrição',
                                       i.qtd as 'Quantidade',
                                       p.preco as 'Valor Unitário',
                                       i.subtotal as 'Valor Total'
                                       
                                       FROM tb_itensvendas as i INNER JOIN tb_produtos as p on (i.produto_id = p.id) WHERE venda_id = @venda_id";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@venda_id", venda_id);
                

                conexao.Open();
                executacmdsql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaItens);

                return tabelaItens;

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
