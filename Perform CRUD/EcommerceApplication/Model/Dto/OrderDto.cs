namespace EcommerceApplication.Model.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
    }
}
