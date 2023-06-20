using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNew.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Synopse { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool HasSeen { get; set; }

        public Show() { }

        public Show(int _id, string _name, string _synopse, string _startDate, string _endDate, bool _hasSeen)
        {
            Id = _id; Name = _name; Synopse = _synopse; StartDate = _startDate; EndDate = _endDate; HasSeen = _hasSeen;
        }
    }
}
