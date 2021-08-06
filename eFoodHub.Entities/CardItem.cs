using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eFoodHub.Entities
{
    public class CardItem
    {
        public CardItem()
        {
            // required by EF
        }
        public CardItem(int itemId, int quantity, decimal unitPrice) 
        {
            ItemId = itemId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public int Id { get; set; }
        public Guid CardId { get; set; }
        public int ItemId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public Card Card { get; set; }
//        public Guid CardId { get; set; }
    }
}
