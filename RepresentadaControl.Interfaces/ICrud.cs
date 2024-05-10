using RepresentadaControl.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepresentadaControl.Interfaces
{
    public interface ICrud<T> where T : class
    {
        string Create(T model);
        void Update(T model);
        void Delete(T model); 
        List<T> GetAll();
        T GetById(int id);



    }
}
