using Projeto_controle_de_vendas.Dao;
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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDao dao = new VendaDao();

            tabelaHistorico.DataSource = dao.listarVendasPorPeriodo(datainicio, datafim);

        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendaDao dao = new VendaDao();

            tabelaHistorico.DataSource = dao.listarVendas();
            tabelaHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abrir outro formulário

            int idvenda = int.Parse(tabelaHistorico.CurrentRow.Cells[0].Value.ToString());

            FrmDetalhesVenda tela = new FrmDetalhesVenda(idvenda);

            DateTime datavenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());


            tela.txtData.Text = datavenda.ToString("dd/MM/yyyy");
            tela.txtCliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();
            

            tela.ShowDialog();
        }
    }
}
