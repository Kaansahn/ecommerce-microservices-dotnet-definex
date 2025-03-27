using System;
using DefineX.Services.ShoppingCartAPI.Models.Dtos;

namespace DefineX.Services.ShoppingCartAPI.Repository;

public interface ICouponRepository
{
    Task<CouponDto> GetCoupon(string couponName);
}
