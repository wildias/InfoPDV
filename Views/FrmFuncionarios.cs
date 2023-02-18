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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Botão Salvar

            Funcionario obj = new Funcionario();

            //Receber os dados dos campos
            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;
            obj.Cargo = cbCargo.SelectedItem.ToString();
            obj.Acesso = cbAcesso.SelectedItem.ToString();
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

            FuncionarioDao dao = new FuncionarioDao();
            dao.CadastrarFuncionario(obj);

            new Helpers().LimparTela(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao Excluir

            Funcionario obj = new Funcionario();
            obj.Id = int.Parse(txtCodigo.Text);

            FuncionarioDao dao = new FuncionarioDao();
            dao.excluirFuncionario(obj);

            //Recarregar o DataGridView

            tabelaFuncionario.DataSource = dao.listarFuncionarios();

            new Helpers().LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo cliente

            Funcionario obj = new Funcionario();

            obj.Nome = txtNome.Text;
            obj.Rg = txtRg.Text;
            obj.Cpf = txtCpf.Text;
            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;
            obj.Cargo = cbCargo.SelectedItem.ToString();
            obj.Acesso = cbAcesso.SelectedItem.ToString();
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

            FuncionarioDao dao = new FuncionarioDao();
            dao.alterarFuncionario(obj);

            //Recarregar DataGridView

            tabelaFuncionario.DataSource = dao.listarFuncionarios();

            new Helpers().LimparTela(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Botao pesquisar

            string nome = txtPesquisa.Text;

            FuncionarioDao dao = new FuncionarioDao();

            tabelaFuncionario.DataSource = dao.buscarFuncionarioPorNome(nome);

            if (tabelaFuncionario.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado!");
                tabelaFuncionario.DataSource = dao.listarFuncionarios();
            }
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

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDao dao = new FuncionarioDao();
            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada

            txtCodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbAcesso.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUf.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            //Alterar para a guia Dados Pessoais

            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FuncionarioDao dao = new FuncionarioDao();
            tabelaFuncionario.DataSource = dao.listarFuncionarioPorNome(nome);
        }

    }
}
