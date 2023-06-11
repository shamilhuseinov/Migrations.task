namespace PurpleBuzz.Models
{
    public class WorkCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
