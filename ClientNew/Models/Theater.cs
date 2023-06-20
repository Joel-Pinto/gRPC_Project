namespace ClientNew.Models
{
    public class Theater
    {
        public int Id { get; set; }
        public string TheaterName { get; set; }
        public string Location { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }

        public Theater () { }

        public Theater (int _id, string _theaterName, string _location, int _contact, string _address)
        {
            this.Id = _id; this.TheaterName = _theaterName; this.Location = _location; this.Contact = _contact; this.Address = _address; 
        }
    }
}
