using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNew.Models
{
    public class LocalHost
    {
        public string Address { get; set; } = "https://localhost:7214";

        public LocalHost() { }

        public LocalHost(string _address)
        {
            Address = _address;
        }
    }
}
