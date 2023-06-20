using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNew.Models
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public int UserPermission { get; set; }

        public User() { }
        public User(int _ID, string _name, string _username, string _location, int _age, int _userPermission) 
        {
            Id = _ID; Name = _name; Username = _username; Location = _location; Age = _age; UserPermission = _userPermission;
        }
    }
}
