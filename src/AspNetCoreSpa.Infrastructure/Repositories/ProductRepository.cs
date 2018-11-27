using Microsoft.EntityFrameworkCore;
using MyCommunity.Core.Entities;

namespace MyCommunity.Infrastructure
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        { }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
