

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        IBLCustomer blManagerCustomers;
        public CustomersController(BLManager blManager)
        {
            this.blManagerCustomers = blManager.Customer;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (blManagerCustomers.GetAll() != null)
            {
                return Ok(blManagerCustomers.GetAll());

            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (blManagerCustomers.Get(id) != null)
            {
                return Ok(blManagerCustomers.Get(id));
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
