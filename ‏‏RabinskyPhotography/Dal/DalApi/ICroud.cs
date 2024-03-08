using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface ICroud<T>
    {
        List<T> GetAll() ;
        T Get(int id);
        T Post(T t) ;
        T Put(T t);
        T Delete(int id) ;
     
            
    }
}
