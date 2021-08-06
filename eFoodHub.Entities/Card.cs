using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eFoodHub.Entities
{
    public class Card
    {
        public Card()
        {
            Items = new List<CardItem>();
            CreatedDate = DateTime.Now;
            IsActive = false;
        }
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual List<CardItem> Items { get; private set; }
        public bool IsActive { get; set; }
    
    
    
    
    
    }
}
