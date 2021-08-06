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
    public class CardRepository : Repository<Card>, ICardRepository
    {
        private AppDbContext appContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }

        public CardRepository(DbContext dbContext): base(dbContext)
        {

        }

        public Card GetCard(Guid CardId)
        {
            return appContext.Cards.Include("Items").Where(c => c.Id == CardId && c.IsActive == true).FirstOrDefault();
        }

        public int DeleteItem(Guid cardId, int itemId)
        {
            throw new NotImplementedException();
        }

        public int UpdateQuantity(Guid cardId, int itemId, int Quantity)
        {
            throw new NotImplementedException();
        }

        public int UpdateCard(Guid cardId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
