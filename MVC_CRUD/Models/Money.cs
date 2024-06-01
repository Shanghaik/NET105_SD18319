using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Models
{
    public class Money
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Serial { get; set; }
        public long Value { get; set; }
    }
}
