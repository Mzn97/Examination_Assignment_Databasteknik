using Examination_Assignment.Contexts;
using Examination_Assignment.Entities;

namespace Examination_Assignment.Repositories;

public class ProductCategoryRepository : Repo<ProductCategoryEntity>
{
    public ProductCategoryRepository(DataContext context) : base(context)
    {
    }
}
