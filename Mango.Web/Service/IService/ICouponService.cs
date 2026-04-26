using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponAsync();
        Task<ResponseDto?> GetCouponAsync(int id);
        Task<ResponseDto?> GetCreateCouponAsync(CouponDto couponCode);
        Task<ResponseDto?> GetUpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> GetDeleteCouponAsync(int id);
        
    }
}
