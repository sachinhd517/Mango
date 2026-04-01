using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object? Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList(); // select * from coupon
                return objList;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public object? Get(int id)
        {
            try
            {
                Coupon objList = _db.Coupons.First(u => u.CouponId == id); // select * from coupon where id = id
                return objList;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return null;
        }
    }
}
