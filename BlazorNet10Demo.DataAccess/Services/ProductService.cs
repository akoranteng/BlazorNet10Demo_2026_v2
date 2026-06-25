using BlazorNet10Demo.DataAccess.Interfaces;
using BlazorNet10Demo.Domain.Models;


namespace BlazorNet10Demo.DataAccess.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Description = "High‑performance laptop",
            Price = 999,
            Quantity = 10,
            ImageUrl = "/images/laptop.png"
        },
        new Product
        {
            Id = 2,
            Name = "Smartphone",
            Description = "Latest model smartphone",
            Price = 799,
            Quantity = 25,
            ImageUrl = "/images/cellphone.png"
        },
        new Product
        {
            Id = 3,
            Name = "Headphones",
            Description = "Noise‑cancelling headphones",
            Price = 199,
            Quantity = 50,
            ImageUrl = "/images/headphones.png"
        },
        new Product
        {
            Id = 4,
            Name = "Tablet",
            Description = "10‑inch tablet",
            Price = 499,
            Quantity = 15,
            ImageUrl = "/images/tablet_1093458.png"
        }
    };

    // READ ALL
    public Task<List<Product>> GetAllAsync()
    {
        return Task.FromResult(_products);
    }

    // READ ONE
    public Task<Product?> GetByIdAsync(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(product);
    }

    // CREATE
    public Task<Product> CreateAsync(Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
        return Task.FromResult(product);
    }

    // UPDATE
    public Task<Product> UpdateAsync(Product product)
    {
        var existing = _products.FirstOrDefault(p => p.Id == product.Id);

        if (existing is not null)
        {
            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            existing.Quantity = product.Quantity;
            existing.ImageUrl = product.ImageUrl;
        }

        return Task.FromResult(existing ?? product);
    }

    // DELETE
    public Task<bool> DeleteAsync(int id)
    {
        var existing = _products.FirstOrDefault(p => p.Id == id);

        if (existing is not null)
        {
            _products.Remove(existing);
            return Task.FromResult(true);
        }

        return Task.FromResult(false);
    }
}

