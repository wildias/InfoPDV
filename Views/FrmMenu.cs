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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastroCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            
            tela.ShowDialog();
        }

        private void consultaCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;

            tela.ShowDialog();
        }

        private void cadastroFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();

            tela.ShowDialog();
        }

        private void consultaFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.tabFuncionarios.SelectedTab = tela.tabPage2;

            tela.ShowDialog();
        }

        private void cadastroFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor tela = new FrmFornecedor();

            tela.ShowDialog();
        }

        private void consultaFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor tela = new FrmFornecedor();
            tela.tabFornecedores.SelectedTab = tela.tabPage2;

            tela.ShowDialog();
        }

        private void cadastroProduto_Click(object sender, EventArgs e)
        {
            FrmProduto tela = new FrmProduto();

            tela.ShowDialog();
        }

        private void consultaProduto_Click(object sender, EventArgs e)
        {
            FrmProduto tela = new FrmProduto();
            tela.tabProdutos.SelectedTab = tela.tabPage2;

            tela.ShowDialog();
        }

        private void novaVenda_Click(object sender, EventArgs e)
        {
            FrmVendas tela = new FrmVendas();

            tela.ShowDialog();
        }

        private void historicoVenda_Click(object sender, EventArgs e)
        {
            FrmHistorico tela = new FrmHistorico();

            tela.ShowDialog();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin tela = new FrmLogin();
            
            tela.ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voce deseja sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
