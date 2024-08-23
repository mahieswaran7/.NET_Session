using ReservationApi.Models;

namespace ReservationApi.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reservation> items;
        public Repository()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>() {
                new Reservation { id = 1, name = "DHARANESH", startLocation = "MADURAI", endLocation = "CHENNAI" },
                new Reservation { id = 2, name = "DHINESH", startLocation = "TIRUNELVELI", endLocation = "CHENNAI" },
                new Reservation { id = 3, name = "ESWARAN", startLocation = "KANCHIPURAM", endLocation = "SINGAPORE" },
                new Reservation { id = 4, name = "LINGAM", startLocation = "CUDDALORE", endLocation = "CHENNAI" }
            }.ForEach(r => AddResrvation(r));
        }

        public Reservation this[int id] => items.ContainsKey(id)
 ? items[id] : null;

        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation AddResrvation(Reservation reservation)
        {
            if (reservation.id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.id = key;
            }
            items[reservation.id] = reservation;
            return reservation;

        }

        public void DeleteResrvation(int id) => items.Remove(id)
;


        public Reservation UpdateResrvation(Reservation reservation) => AddResrvation((Reservation)reservation);

    }
}