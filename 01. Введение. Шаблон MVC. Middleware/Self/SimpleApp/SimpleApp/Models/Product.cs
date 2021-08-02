namespace SimpleApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Count { get; set; }

        public string Description { get; set; }

        public string Info 
        { 
            get 
            {
                if (Count == 0)
                    return "нет в наличии";
                if (Count <= 5)
                    return "заканчивается";

                return "в наличии";
            } 
        }
    }
}
