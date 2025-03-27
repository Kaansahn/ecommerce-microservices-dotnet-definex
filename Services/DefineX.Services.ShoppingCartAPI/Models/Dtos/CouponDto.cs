using System;

namespace DefineX.Services.ShoppingCartAPI.Models.Dtos;

public class CouponDto
{
    public int CouponId { get; set; }
    public string CouponCode { get; set; }
    public double DiscountAmount { get; set; }
}
