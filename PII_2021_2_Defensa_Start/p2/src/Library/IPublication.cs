namespace Ucu.Poo.Defense
{
    public interface IPublication
    {
        Material Material { get; set; }

        int Quantity { get; set; }

        int Price { get; set; }

        int SubTotal { get; set; }
    }
}
