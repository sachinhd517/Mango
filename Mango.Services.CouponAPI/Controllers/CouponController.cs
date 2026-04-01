using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        public CouponController(AppDbContext db)
        {
            _db = db;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto? Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList(); // select * from coupon
                _response.Result = objList;
            }
            catch (Exception ex)
            {
                //ex.Message.ToString();
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto? Get(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(u => u.CouponId == id); // select * from coupon where id = id
                _response.Result = obj;
            }
            catch (Exception ex)
            {
                //ex.Message.ToString();
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
