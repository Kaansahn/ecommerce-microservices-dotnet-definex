using System;
using AutoMapper;
using DefineX.Services.ShoppingCartAPI.Models;
using DefineX.Services.ShoppingCartAPI.Models.Dtos;

namespace DefineX.Services.ShoppingCartAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ProductDto, Product>().ReverseMap();
            config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
            config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            config.CreateMap<Cart, CartDto>().ReverseMap();
        });

        return mappingConfig;
    }
}
