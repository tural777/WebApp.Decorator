using WebApp.Decorator.Models;

namespace WebApp.Decorator.Repositories.Decorator;

public class ProductRepositoryLoggingDecorator : BaseProductRepositoryDecorator
{
    private readonly ILogger<ProductRepositoryLoggingDecorator> _log;

    public ProductRepositoryLoggingDecorator(IProductRepository productRepository, ILogger<ProductRepositoryLoggingDecorator> log) : base(productRepository)
    {
        _log = log;
    }

    public override Task<List<Product>> GetAll()
    {
        _log.LogInformation("GetAll methodu işlədi");
        return base.GetAll();
    }

    public override Task<List<Product>> GetAll(string userId)
    {
        _log.LogInformation("GetAll(userId) methodu işlədi");
        return base.GetAll(userId);
    }

    public override Task<Product> Save(Product product)
    {
        _log.LogInformation("Save methodu işlədi");
        return base.Save(product);
    }

    public override Task Update(Product product)
    {
        _log.LogInformation("Update methodu işlədi");
        return base.Update(product);
    }

    public override Task Remove(Product product)
    {
        _log.LogInformation("Remove methodu işlədi");
        return base.Remove(product);
    }
}