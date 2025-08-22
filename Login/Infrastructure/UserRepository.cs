using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Infrastructure
{
    internal class UserRepository
    {
        public bool Add(User user)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO usuarios (username, senha) VALUES (@username, @senha)";
            var result = conn.Connection.Execute(sql: query, param: user);
            return result == 1;
        }
        public List<User> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM usuarios";
            var usuarios = conn.Connection.Query<User>(sql: query);
            return usuarios.ToList();
        }

    }
}
