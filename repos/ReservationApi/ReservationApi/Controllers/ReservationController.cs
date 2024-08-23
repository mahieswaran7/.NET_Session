using Microsoft.AspNetCore.Mvc;
using ReservationApi.Models;

namespace ReservationApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private IRepository repository;

        public ReservationController(IRepository repo) => repository = repo;

        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;

        [HttpGet("{id}")]

        public ActionResult<Reservation> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("value must be passed");

            }
            return Ok(repository[id]);

        }
        [HttpPost]

        public Reservation Post([FromBody] Reservation res) =>
            repository.AddResrvation(new Reservation
            {
                name = res.name,
                startLocation = res.startLocation,
                endLocation = res.endLocation 

            });

        [HttpPut]

        public Reservation Put([FromForm] Reservation res) => repository.UpdateResrvation(res);

        [HttpDelete("{id}")]

        public void Delete(int id) => repository.DeleteResrvation(id)

;



    }
}