using System.Collections.Generic;

namespace Repository.Interface
{
    /// <summary>
    /// Interface para a classe base de repositório
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> 
    {
        bool Add(T obj);
        IEnumerable<T> List();
    }
}
