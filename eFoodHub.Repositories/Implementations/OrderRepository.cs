using eFoodHub.Entities;
using eFoodHub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodHub.Repositories.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private AppDbContext appContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }

        public OrderRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Order> GetUsersOrder(int userId)
        {
            return appContext.Orders

                .Include(o => o.OrderItems)
                .Where(x => x.UserId == userId).ToList();
        }
    }
}
