namespace OnlineStore_WinformsUI.Models
{
    internal class Order
    {
        public string Number { get; set; }

        public double Total { get; set; }

        public DateTime CreationDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public OrderState State { get; set; }
    }
}
