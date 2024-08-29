using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;

namespace ReservationAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private IRepository repository;
        public ReservationController(IRepository repo) => repository = repo;

        [HttpGet]

        public IEnumerable<Reservation> Get() => repository.Resevation;

        [HttpGet("{id}")]

        public ActionResult<Reservation> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("value must be passed in the request body");
            }
            return Ok(repository[id]);
        }

        [HttpPost]
        public Reservation post([FromBody] Reservation res) => repository.AddReservation(new Reservation
        {
            Name = res.Name,
            StartLocation = res.StartLocation,
            EndLocation = res.EndLocation
        });

        [HttpPut]

        public Reservation Put([FromForm] Reservation res) => repository.UpdateReservation(res);

        [HttpDelete("{id}")]

        public void Delete(int id) {

            Console.WriteLine(id);
             repository.DeleteReservation(id);

            }
    }
}
