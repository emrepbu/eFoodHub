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
            var item = appContext.CardItems.Where(ci => ci.CardId == cardId && ci.Id == itemId).FirstOrDefault();
            if (item != null)
            {
                appContext.CardItems.Remove(item);
                return appContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int UpdateQuantity(Guid cardId, int itemId, int Quantity)
        {
            bool flag = false;
            var card = GetCard(cardId);
            if (card!= null)
            {
                for (int i = 0; i < card.Items.Count; i++)
                {
                    if (card.Items[i].Id == itemId)
                    {
                        flag = true;
                        if (Quantity < 0 && card.Items[i].Quantity > 1 )
                        {
                            card.Items[i].Quantity += (Quantity);
                        }
                        else if(Quantity > 0)
                        {
                            card.Items[i].Quantity += (Quantity);
                        }
                        break;
                    }
                }
                if (flag)
                {
                    return appContext.SaveChanges();
                }
            }
            return 0;
        }

        public int UpdateCard(Guid cardId, int userId)
        {
            Card card = GetCard(cardId);
            card.UserId = userId;
            return appContext.SaveChanges();
        }
         
    }
}
