namespace СlothingStore.API.Models
{
    public class Clothes
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public float Size { get; set; }

        public Clothes(string name, int amount, string brand, string color, float size)
        {
            Name = name;
            Amount = amount;
            Brand = brand;
            Color = color;
            Size = size;
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