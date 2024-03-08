

namespace Bl.BlApi
{
    public interface IBLCroud<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Post(T t);
        T Put(int id);
        T Delete(int id);
    }
}
