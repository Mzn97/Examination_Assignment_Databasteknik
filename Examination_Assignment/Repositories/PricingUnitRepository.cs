using Examination_Assignment.Contexts;
using Examination_Assignment.Entities;

namespace Examination_Assignment.Repositories;

public class PricingUnitRepository : Repo<PricingUnitEntity>
{
    public PricingUnitRepository(DataContext context) : base(context)
    {
    }
}