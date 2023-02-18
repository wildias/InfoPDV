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
    public partial class FrmDetalhesVenda : Form
    {
        int venda_id;
        public FrmDetalhesVenda(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void FrmDetalhesVenda_Load(object sender, EventArgs e)
        {
            ItemVendaDao dao = new ItemVendaDao();
            tabelaDetalhes.DataSource = dao.listarItensPorVendas(venda_id);
        }
    }
}
