using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepresentadaControl.Data
{
    public class Produto : BaseModel
    {
        public int IdFornecedor { get; set; }
        public string CodigoFornecedor { get; set; }
        public string Nome { get; set;}
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo {  get; set; }

    }
}
