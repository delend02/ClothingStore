namespace СlothingStore.API.Models
{
    public class Clothes
    {
        public ulong ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public float Size { get; set; }
        public decimal Price { get; set; }

        public Clothes(ulong id, string name, int amount, string brand, string color, float size, decimal price)
        {
            ID = id;
            Name = name;
            Amount = amount;
            Brand = brand;
            Color = color;
            Size = size;
            Price = price;  
        }



        public override string ToString()
        {
            return $"Name: {Name}" +
                   $"\nAmount: {Amount}" +
                   $"\nBrand: {Brand}" +
                   $"\nColor: {Color}" +
                   $"\nSize: {Size}";
        }


    }
}