using eFoodHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodHub.Repositories.Interfaces
{
    public interface ICardRepository : IRepository<Card>
    {
        Card GetCard(Guid CardId);

        int DeleteItem(Guid cardId, int itemId);
        int UpdateQuantity(Guid cardId, int itemId, int Quantity);
        int UpdateCard(Guid cardId, int userId);
    }
}
