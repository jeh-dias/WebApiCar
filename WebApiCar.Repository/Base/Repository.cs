using Dapper;
using Repository.Interface;
using System.Collections.Generic;
using WebApiCar.Domain;
using Dapper.Contrib.Extensions;

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
        private readonly IConfiguration _connectionString;

        public Repository(IConfiguration connectionString)
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
            _connectionString = connectionString;
        }

        public bool Add(T obj)
        {
            using (var conn = _connectionString)
            {
                var result = conn.Insert(obj);
            }
            return true;
        }

        public IEnumerable<T> List()
        {
            using (var conn = _connectionString)
            {
                return conn.GetAll<T>();
            }
        }
    }
}
