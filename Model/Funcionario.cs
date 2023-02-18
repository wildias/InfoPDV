using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_controle_de_vendas.Model
{
    public class Funcionario : Cliente
    {
        //Atributos e os Getter / Setter

        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Acesso { get; set; }

    }
}
