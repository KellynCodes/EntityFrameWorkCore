using System.ComponentModel.DataAnnotations;

namespace EfCore.DAL.Models
{
    public class Tasks : BaseEntity
    {
        //Using Data annotations example
        [Required, StringLength(20, ErrorMessage = "Name can not be greater than 20")]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
