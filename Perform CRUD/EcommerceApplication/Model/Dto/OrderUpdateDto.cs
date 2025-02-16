namespace EcommerceApplication.Model.Dto
{
    public class OrderUpdateDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public float Price { get; set; }
        public bool IsActive { get; set; }
    }
}
