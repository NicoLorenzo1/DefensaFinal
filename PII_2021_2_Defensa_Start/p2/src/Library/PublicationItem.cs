namespace Ucu.Poo.Defense
{
    public class PublicationItem : IPublication
    {
        public Material Material { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }
        public int SubTotal { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public PublicationItem(Material material, int quantity, int price)
        {
            this.Material = material;
            this.Quantity = quantity;
            this.Price = price;
        }

    }
}