using System;
using AutoMapper;
using DefineX.Services.ProductAPI.DbContexts;
using DefineX.Services.ProductAPI.Dtos;
using DefineX.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DefineX.Services.ProductAPI.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _db;
    private IMapper _mapper;

    public ProductRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
    {
        Product product = _mapper.Map<ProductDto, Product>(productDto);
        //If the ProductId greater than 0, update it
        if (product.ProductId > 0)
        {
            _db.Products.Update(product);
        }
        //If it is not, create a new Product.
        else
        {
            _db.Products.Add(product);
        }
        await _db.SaveChangesAsync();
        //kayıt eklendikten sonra databaseden eklenen product objesi geriye produtcDto olarak döndürülür
        return _mapper.Map<Product, ProductDto>(product);
    }

    public async Task<bool> DeleteProduct(int productId)
    {
        try
        {
            Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
            if (product == null)
            {
                return false;
            }
            _db.Products.Remove(product); //delete from Product where Id=productId
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<ProductDto> GetProductById(int productId)
    {
        //linq select * from Product where Id=productId
        //{Id:1,Name : Product1}
        Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
        return _mapper.Map<ProductDto>(product);
    }

    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        List<Product> productList = await _db.Products.ToListAsync();
        return _mapper.Map<List<ProductDto>>(productList);
    }
}
