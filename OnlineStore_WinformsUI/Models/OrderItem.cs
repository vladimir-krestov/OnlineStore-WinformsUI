namespace OnlineStore_WinformsUI.Models
{
    internal class OrderItem
    {
        public Pizza Pizza { get; set; }

        public PizzaSize PizzaSize { get; set; }

        public DoughType DoughType { get; set; }

        public int PizzaCount { get; set; }

        public string OrderNumber { get; set; }
    }
}
