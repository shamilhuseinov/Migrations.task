using System.ComponentModel.DataAnnotations;

namespace PurpleBuzz.ViewModels.WorkCategory
{
    public class WorkCategoryCreateVM
    {
        [MaxLength(10, ErrorMessage = "Adın uzunluğu maksimum 10 olmalıdır")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "AÇıqlamanın uzunluğu maksimum 100 olmalıdır")]
        public string Description { get; set; }
    }
}
