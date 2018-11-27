using Microsoft.EntityFrameworkCore;
using MyCommunity.Core.Entities;

namespace MyCommunity.Infrastructure
{
    public class OrdersRepository : Repository<Order>, IOrdersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        { }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
