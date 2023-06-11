namespace PurpleBuzz.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public int WorkCategoryId { get; set; }
        public WorkCategory WorkCategory { get; set; }
    }
}
