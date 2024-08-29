namespace ReservationAPI.Models
{
    public interface IRepository
    {
        IEnumerable<Reservation> Resevation { get; }

        Reservation this[int id] { get; }

        Reservation AddReservation(Reservation reservation);

        Reservation UpdateReservation(Reservation reservation);

        void DeleteReservation(int id);

    }
}
