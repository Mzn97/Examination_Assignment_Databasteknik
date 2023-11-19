using Examination_Assignment.Contexts;
using Examination_Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Examination_Assignment.Repositories;

public class ProductRepository : Repo<ProductEntity>
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        return await _context.Products
            .Include(x => x.PricingUnit)
            .Include(x => x.ProductCategory)
            .ToListAsync();
    }
}