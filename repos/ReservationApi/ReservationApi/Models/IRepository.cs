using ReservationApi.Models;

namespace ReservationApi.Models
{
    public interface IRepository
    {
        IEnumerable<Reservation> Reservations { get; }

        Reservation this[int id] { get; }

        Reservation AddResrvation(Reservation reservation);

        Reservation UpdateResrvation(Reservation reservation);

        void DeleteResrvation(int id);
    }
}