using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaWeb.Entidades
{
    public class PessoaJuridica : Usuario
    {
        public virtual string CNPJ { get; set; }
    }
}
