using Dapper;
using Repository.Interface;
using System.Collections.Generic;
using WebApiCar.Domain;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using WebApiCar.Repository.Utilities;

namespace Repository.Base
{
    /// <summary>
    /// Repositório base, responsável pelas operações de
    /// adição e listagem de qualquer entidade
    /// Há uma verificação no construtor para seguir o padrão singleton
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T> where T  : class
    {
        public static List<T> _list { get; set; }
        public static object _syncObj = new object();
        private readonly IConfiguration _config;

        public Repository(IConfiguration config)
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
            _config = config;
        }

        public bool Add(T obj)
        {
            using (var conn = ConnectionFactory.GetConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var result = conn.Insert<T>(obj);
            }
            return true;
        }

        public IEnumerable<T> List()
        {
            using (var conn = ConnectionFactory.GetConnection(_config.GetConnectionString("DefaultConnection")))
            {
                return conn.GetAll<T>();
            }
        }
    }
}
