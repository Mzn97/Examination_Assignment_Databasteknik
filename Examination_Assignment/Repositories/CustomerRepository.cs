using Examination_Assignment.Contexts;
using Examination_Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Examination_Assignment.Repositories;

public class CustomerRepository : Repo<CustomerEntity>
{
    private readonly DataContext _context;

    public CustomerRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<CustomerEntity>> GetAllAsync()
    {
        return await _context.Customers.Include(x => x.Address).ToListAsync();
    }
}