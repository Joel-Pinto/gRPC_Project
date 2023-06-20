using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNew.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int Id_Show { get; set; }
        public DateTime Date { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }


        public Session() { }

        public Session(int _id, int _idShow, DateTime _date, string _startHour, string _endHour, int _totalSeats, int _availableSeats)
        {
            Id = _id; Id_Show = _idShow; Date = _date; StartHour = _startHour; EndHour = _endHour; TotalSeats = _totalSeats; AvailableSeats = _availableSeats;
        }
    }
}