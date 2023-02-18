using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_controle_de_vendas.Model
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int Venda_id { get; set; }
        public int Produto_id { get; set; }
        public int Qtd { get; set; }
        public decimal Subtotal { get; set; }
    }
}
