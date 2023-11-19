using Examination_Assignment.Contexts;
using Examination_Assignment.Entities;

namespace Examination_Assignment.Repositories;

public class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}