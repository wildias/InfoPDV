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
    public partial class FrmVendas : Form
    {
        //Objeto Cleinte e ClienteDao
        Cliente cliente = new Cliente();
        ClienteDao cdao = new ClienteDao();

        //Objetos de Produto
        Produto p = new Produto();
        ProdutoDao pdao = new ProdutoDao();

        //Variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        //Carrinho
        DataTable carrinho = new DataTable();


        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProduto.DataSource = carrinho;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cliente = cdao.retornarClientePorCpf(txtCpf.Text);

                if(cliente != null)
                {

                txtNome.Text = cliente.Nome;

                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.retornarProdutoPorCodigo(int.Parse(txtCodigo.Text));

                if(p != null) 
                {
                    txtDescricao.Text = p.Descricao;
                    txtPreco.Text = p.Preco.ToString();

                }
                else
                {
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão Add item

                qtd = int.Parse(txtQtd.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                //Add item ao Carrinho

                carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDescricao.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();

                //Limpar os Campos

                txtCodigo.Clear();
                txtDescricao.Clear();
                txtQtd.Clear();
                txtPreco.Clear();

                txtCodigo.Focus();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o código do produto!" + erro);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Botão Remover item

            decimal subproduto = decimal.Parse(tabelaProduto.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProduto.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];
            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();
            total -= subproduto;
            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //Botão Pagamento
            DateTime dataatual = DateTime.Parse(txtData.Text);

            FrmPagamento tela = new FrmPagamento(cliente, carrinho, dataatual);

            //Passando o total para a tela de pagamentos

            tela.txtTotal.Text = total.ToString();

            tela.ShowDialog();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual

            txtData.Text = DateTime.Now.ToShortDateString();
        }
    }
}
