using RepresentadaControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepresentadaControl.Interfaces
{
    public class BaseCrud<T> : ICrud<T> where T : BaseModel   
    {
        public virtual string Create(T model)
        {
            return "Criado com sucesso";
        }

        public virtual void Delete(T model)
        {
            
        }

        public virtual List<T> GetAll()
        {
            List<T> clientes = new List<T>();
            T c1 = Activator.CreateInstance<T>();
            clientes.Add(c1);
            return clientes;
        }

        public virtual T GetById(int id)
        {
            T c1 = Activator.CreateInstance<T>();
            return c1;
        }

        public virtual void Update(T model)
        {
            
        }
    }
}
