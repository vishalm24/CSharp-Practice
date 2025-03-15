using EcommerceApplication.Model.Dto;

namespace EcommerceApplication.Pagination
{
    public record PagedResponseOffset
    {
        public List<UserDto> Data { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public PagedResponseOffset(List<UserDto> data, int pageSize, int pageNumber, int totalRecords)
        {
            Data = data;
            PageSize = pageSize;
            PageNumber = pageNumber;
            TotalRecords = totalRecords;
            TotalPages = (int)Math.Ceiling((decimal) TotalRecords / (decimal) PageSize);
        }
    }
}
