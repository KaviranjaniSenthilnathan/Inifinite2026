using System.Linq;
using System.Web.Http;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        [HttpGet]
        [Route("bycountry/{country}")]
        public IHttpActionResult GetCustomers(string country)
        {
            var data = db.GetCustomersByCountry(country).ToList();
            return Ok(data);
        }
    }
}