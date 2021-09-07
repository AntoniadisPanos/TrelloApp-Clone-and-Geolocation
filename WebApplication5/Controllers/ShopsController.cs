using System.Data;
using System.Linq;
using System.Web.Http;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ShopsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Shops
        public IHttpActionResult GetShops()
        {
            return Ok(db.Shops.Select(x => new { name = x.Name, lat = x.Lat, lng = x.Lng }));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShopExists(int id)
        {
            return db.Shops.Count(e => e.Id == id) > 0;
        }
    }
}