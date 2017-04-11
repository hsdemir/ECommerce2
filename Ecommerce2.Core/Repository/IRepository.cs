using System.Collections.Generic;

namespace Ecommerce2.Core.Repository
{
    public interface IRepository<T,Tdto> where T : class
    {
        Tdto Get(int id);
        ICollection<Tdto> List();
        int Insert(Tdto dto);
        int Update(Tdto dto);
        int Delete(int id);
    }
}
