namespace EcommerceApplication.Model.Dto
{
    public class ProductAddDto
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive = true;
        //public string CategoryName { get; set; }
    }
}
