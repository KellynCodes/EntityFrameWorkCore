namespace EfCore.DAL.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Tasks> Tasks { get; set; }
    }
}
