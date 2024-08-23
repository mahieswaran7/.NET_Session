namespace ReservationApi.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public string name { get; set; }

        public string startLocation { get; set; }

        public string endLocation { get; set; }
    }
}