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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDao dao = new ClienteDao();
            
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botao pesquisar

            string nome = txtPesquisa.Text;

            ClienteDao dao = new ClienteDao();

            tabelaCliente.DataSource = dao.buscarClientePorNome(nome);

            if(tabelaCliente.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Cliente não encontrado!");
                tabelaCliente.DataSource = dao.listarClientes();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Cliente obj = new Cliente();

            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
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

            ClienteDao dao = new ClienteDao();
            dao.CadastrarCliente(obj);

            tabelaCliente.DataSource = dao.listarClientes();

            new Helpers().LimparTela(this);

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Pegar os dados da linha selecionada

            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia Dados Pessoais

            tabClientes.SelectedTab = tabPage1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botão Excluir

            Cliente obj = new Cliente();

            //Pegar o código

            obj.Id = int.Parse(txtCodigo.Text);

            ClienteDao dao = new ClienteDao();
            dao.excluirCliente(obj);

            //Recarregar o DataGridView

            tabelaCliente.DataSource = dao.listarClientes();

            new Helpers().LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Cliente obj = new Cliente();

            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
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
            obj.Id = int.Parse(txtCodigo.Text);

            // 2 passo - Criar um objeto da classe ClienteDao e chamar o metodo CadastarCliente

            ClienteDao dao = new ClienteDao();
            dao.alterarCliente(obj);

            //Recarregar DataGridView

            tabelaCliente.DataSource = dao.listarClientes();

            new Helpers().LimparTela(this);

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            ClienteDao dao = new ClienteDao();

            tabelaCliente.DataSource = dao.listarClientePorNome(nome);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            ClienteDao dao = new ClienteDao();
            tabelaCliente.DataSource = dao.listarClientePorNome(nome);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Botao Consultar CEP

            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

    }
}
