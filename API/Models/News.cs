using API.Models.Enums;

namespace API.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public NewsType NewsType { get; set; }
    }
}
