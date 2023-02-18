using Projeto_controle_de_vendas.Dao;
using Projeto_controle_de_vendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_controle_de_vendas.Views
{
    public partial class FrmPagamento : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public FrmPagamento(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;
            
            
            InitializeComponent();
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            //Carregar Tela

            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Botao Finalizar Venda

            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                ProdutoDao dao_produto = new ProdutoDao();

                int qtd_estoque, qtd_comprada, qtd_atualizada;

                v_dinheiro = decimal.Parse(txtDinheiro.Text);
                v_cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                //Calcular o total pago

                totalpago = v_dinheiro + v_cartao;

                if(totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda!");
                }
                else
                {
                    //Calcular o troco

                    troco = totalpago - total;

                    Venda venda = new Venda();

                    venda.Cliente_id = cliente.Id;
                    venda.Data_venda = dataatual;
                    venda.Total_venda = total;
                    venda.Obs = txtObs.Text;

                    VendaDao vdao = new VendaDao();
                    txtTroco.Text = troco.ToString();

                    vdao.cadastrarVenda(venda);

                    //Cadastrar os itens da venda

                    foreach(DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();
                        item.Venda_id = vdao.retornarIdUltimaVenda();
                        item.Produto_id = int.Parse(linha["Código"].ToString());
                        item.Qtd = int.Parse(linha["Qtd"].ToString());
                        item.Subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        //baixa no estoque

                        qtd_estoque = dao_produto.retornarEstoqueAtual(item.Produto_id);
                        qtd_comprada = item.Qtd;
                        qtd_atualizada = qtd_estoque - qtd_comprada;

                        dao_produto.baixarEstoque(item.Produto_id, qtd_atualizada);

                        ItemVendaDao itemdao = new ItemVendaDao();
                        itemdao.cadastrarItem(item);

                        
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");

                    this.Dispose();

                    new FrmVendas().ShowDialog();


                }

                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
