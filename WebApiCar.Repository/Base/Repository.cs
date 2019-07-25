using Dapper;
using Repository.Interface;
using System.Collections.Generic;
using WebApiCar.Domain;
using WebApiCar.Repository.Query;
using WebApiCar.Repository.Utilities;

namespace Repository.Base
{
    /// <summary>
    /// Repositório base, responsável pelas operações de
    /// adição e listagem de qualquer entidade
    /// Há uma verificação no construtor para seguir o padrão singleton
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T>
    {
        public static List<T> _list { get; set; }
        public static object _syncObj = new object();
        private string query = "select * from Car";

        public Repository()
        {
            if(_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }
        }

        public bool Add(T obj)
        {
            _list.Add(obj);
            return true;
        }

        public IEnumerable<T> List()
        {
            var conn = ConnectionFactory.GetConnection();

            var result = conn.Query<T>(query);

            return result;
        }
    }
}
