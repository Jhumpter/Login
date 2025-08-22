using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    [Table("usuarios")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string senha { get; set; }
        public User(){}
        public User(string name, string password)
        {
            username = name;
            senha = password;
        }
    }
}
