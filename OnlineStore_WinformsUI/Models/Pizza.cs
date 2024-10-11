namespace OnlineStore_WinformsUI.Models
{
    internal class Pizza
    {
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public PizzaCategory Category { get; set; }
    }
}
