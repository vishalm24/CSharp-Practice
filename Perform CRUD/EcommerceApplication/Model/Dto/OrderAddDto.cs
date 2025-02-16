namespace EcommerceApplication.Model.Dto
{
    public class OrderAddDto
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public bool IsActive = true;
    }
}
