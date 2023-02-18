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
    public partial class FrmFornecedor : Form
    {

        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Botao pesquisar

            string nome = txtPesquisa.Text;

            FornecedorDao dao = new FornecedorDao();
            

            tabelaFornecedor.DataSource = dao.buscarFornecedorPorNome(nome);

            if (tabelaFornecedor.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Fornecedor não encontrado!");
                tabelaFornecedor.DataSource = dao.listarFornecedor();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.Nome = txtNome.Text;
            obj.Cnpj = txtCnpj.Text;
            obj.Email = txtEmail.Text;        
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCep.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Uf = cbUf.SelectedItem.ToString();

            //Criar o objeto FuncinárioDao

            FornecedorDao dao = new FornecedorDao();
            dao.CadastrarFornecedor(obj);

            new Helpers().LimparTela(this);
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDao dao = new FornecedorDao();

            tabelaFornecedor.DataSource = dao.listarFornecedor();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botão Excluir

            Fornecedor obj = new Fornecedor();

            //Pegar o código

            obj.Id = int.Parse(txtCodigo.Text);

            FornecedorDao dao = new FornecedorDao();
            dao.excluirFornecedor(obj);

            //Recarregar o DataGridView

            tabelaFornecedor.DataSource = dao.listarFornecedor();

            new Helpers().LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Fornecedor obj = new Fornecedor();

            obj.Nome = txtNome.Text;
            obj.Cnpj = txtCnpj.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCep.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Uf = cbUf.SelectedItem.ToString();

            // 2 passo - Criar um objeto da classe ClienteDao e chamar o metodo CadastarCliente

            FornecedorDao dao = new FornecedorDao();
            dao.alterarFornecedor(obj);

            //Recarregar DataGridView

            tabelaFornecedor.DataSource = dao.listarFornecedor();

            new Helpers().LimparTela(this);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FornecedorDao dao = new FornecedorDao();
            tabelaFornecedor.DataSource = dao.listarFornecedorPorNome(nome);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Botao Consultar CEP

            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }

        private void tabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada

            txtCodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbUf.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            //Alterar para a guia Dados Pessoais

            tabFornecedores.SelectedTab = tabPage1;
        }

    }
}
