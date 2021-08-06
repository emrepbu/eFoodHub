using eFoodHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodHub.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetUsersOrder(int userId);

    }
}
