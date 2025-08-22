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
        private readonly DbConnection _context = new DbConnection();
        public void Add(User user)
        {
            _context.Usuarios.Add(user);
            _context.SaveChanges();
        }
        public List<User> Get()
        {
            return _context.Usuarios.ToList();
        }

    }
}
