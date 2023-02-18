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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            FornecedorDao f_dao = new FornecedorDao();

            cbFornecedor.DataSource = f_dao.listarFornecedor();
            cbFornecedor.DisplayMember = "nome" ;
            cbFornecedor.ValueMember = "id";

            ProdutoDao dao = new ProdutoDao();
            tabelaProduto.DataSource = dao.listarProduto();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.Descricao = txtDescricao.Text;
            obj.Preco = decimal.Parse(txtPreco.Text);
            obj.Estoque = int.Parse(txtEstoque.Text);
            obj.For_id = int.Parse(cbFornecedor.SelectedValue.ToString());


            //Criar o objeto FuncinárioDao

            ProdutoDao dao = new ProdutoDao();
            dao.CadastrarProduto(obj);

            new Helpers().LimparTela(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botão Excluir

            Produto obj = new Produto();

            //Pegar o código

            obj.Id = int.Parse(txtCodigo.Text);

            ProdutoDao dao = new ProdutoDao();
            dao.excluirProduto(obj);

            new Helpers().LimparTela(this);

            //Recarregar o DataGridView

            tabelaProduto.DataSource = dao.listarProduto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Produto obj = new Produto();

            obj.Descricao = txtDescricao.Text;
            obj.Preco = decimal.Parse(txtPreco.Text);
            obj.Estoque = int.Parse(txtEstoque.Text);
            obj.For_id = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.Id = int.Parse(txtCodigo.Text);

            // 2 passo - Criar um objeto da classe ClienteDao e chamar o metodo CadastarCliente

            ProdutoDao dao = new ProdutoDao();
            dao.alterarProduto(obj);

            new Helpers().LimparTela(this);

            //Recarregar DataGridView

            tabelaProduto.DataSource = dao.listarProduto();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Botao pesquisar

            string nome = txtPesquisa.Text;

            ProdutoDao dao = new ProdutoDao();


            tabelaProduto.DataSource = dao.buscarProdutoPorNome(nome);

            if (tabelaProduto.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Fornecedor não encontrado!");
                tabelaProduto.DataSource = dao.listarProduto();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string descricao = "%" + txtPesquisa.Text + "%";

            ProdutoDao dao = new ProdutoDao();
            tabelaProduto.DataSource = dao.listarProdutoPorNome(descricao);
        }

        private void tabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada

            txtCodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = tabelaProduto.CurrentRow.Cells[4].Value.ToString();
            

            //Alterar para a guia Dados Pessoais

            tabProdutos.SelectedTab = tabPage1;
        }

    }
}
