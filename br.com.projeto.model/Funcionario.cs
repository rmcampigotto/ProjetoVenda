using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleVendas.br.com.projeto.model
{
    public class Funcionario : Client
    {

        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Nivel_Acesso { get; set; }
    }
}
