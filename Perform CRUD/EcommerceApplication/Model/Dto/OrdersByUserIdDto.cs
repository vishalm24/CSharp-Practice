namespace EcommerceApplication.Model.Dto
{
    public class OrdersByUserIdDto
    {
        public Guid orderId { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public string categoryName { get; set; }
    }
}
