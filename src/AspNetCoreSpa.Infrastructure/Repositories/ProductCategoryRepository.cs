using Microsoft.EntityFrameworkCore;
using MyCommunity.Core.Entities;

namespace MyCommunity.Infrastructure
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DbContext context) : base(context)
        { }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
