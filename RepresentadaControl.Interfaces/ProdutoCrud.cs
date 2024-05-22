using RepresentadaControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepresentadaControl.Interfaces
{
    public class ProdutoCrud : BaseCrud<Produto>
    {
        public override string Create(Produto model)
        {
            if (model.Preco != 0)
            {
                return base.Create(model);
            }
            return "Preço deve ser diferente de 0";
        }
    }
}
