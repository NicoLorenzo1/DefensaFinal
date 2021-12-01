using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication : IPublication
    {
        public DateTime EndDate { get; set; }
        private IList<PublicationItem> items = new List<PublicationItem>();

        public List<PublicationItem> Items
        {
            get
            {
                return new List<PublicationItem>(this.items);
            }
        }

        public IList<PublicationItem> Item { get; private set; }
        public Material Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SubTotal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }
        public string TextoImprimir(DateTime endDate, PublicationItem items)
        {
            return $"{Quantity} + {items} + {endDate} + a $ + {Price}";
        }
    }
}