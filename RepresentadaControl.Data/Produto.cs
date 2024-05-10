using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepresentadaControl.Data
{
    public class Produto : BaseModel
    {
        public int IdManufactory { get; set; }
        public int Code { get; set; }
        public string ManufactoryCode { get; set; }
        public string Name { get; set;}
        public decimal Price { get; set; }

    }
}
