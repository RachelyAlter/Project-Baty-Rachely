

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotographersController : ControllerBase
    {
        IBLPhotographer blManagerPhotographers;
        public PhotographersController(BLManager blManager)
        {
            this.blManagerPhotographers = blManager.Photographer;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (blManagerPhotographers.GetAll() != null)
            {
                return Ok(blManagerPhotographers.GetAll());

            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (blManagerPhotographers.Get(id) != null)
            {
                return Ok(blManagerPhotographers.Get(id));
            }
            return BadRequest();
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

