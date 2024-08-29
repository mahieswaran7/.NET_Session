
using Microsoft.AspNetCore.Http.Features;

namespace ReservationAPI.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reservation> Items;
        public Repository()
        {
            Items = new Dictionary<int, Reservation>();
            new List<Reservation>
            {
                new Reservation{Id=1,Name="Vijay",StartLocation="Chennai",EndLocation="Goa"},
                new Reservation{Id=2,Name="karupu",StartLocation="Karakudi",EndLocation="Chennai"},
                new Reservation{Id=3,Name="Hamsa",StartLocation="Pune",EndLocation="Delhi"},
                new Reservation{Id=4,Name="Ikfan",StartLocation="Chennai",EndLocation="Simla"}
                 }.ForEach(r => AddReservation(r));
        }

        public Reservation this[int id] =>Items.ContainsKey(id) ? Items[id]:null;

        public IEnumerable<Reservation> Resevation => Items.Values;

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation.Id == 0)
            {
                int key = Items.Count;
                while (Items.ContainsKey(key)) { key++; };
                reservation.Id = key;

            }
            Items[reservation.Id] = reservation;
            return reservation;
        }
        public void DeleteReservation(int id) => Items.Remove(id);


        public Reservation UpdateReservation(Reservation reservation) => AddReservation(reservation);



    }

}
