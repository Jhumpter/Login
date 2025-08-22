using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Infrastructure
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; private set; }

        public DbConnection()
        {
            Connection = new NpgsqlConnection("User ID=postgres;Password=8888;Host=localhost;Port=5432;Database=Login;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
