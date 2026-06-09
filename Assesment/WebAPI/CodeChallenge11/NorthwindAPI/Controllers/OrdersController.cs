using System.Linq;
using System.Web.Http;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        [HttpGet]
        [Route("buchanan")]
        public IHttpActionResult GetOrders()
        {
            var data = db.Orders
                         .Where(o => o.EmployeeID == 5)
                         .ToList();

            return Ok(data);
        }
    }
}