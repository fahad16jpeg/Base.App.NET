using System.ComponentModel.DataAnnotations;
using Vista.App.Data;
namespace Vista.app.Data
{
    public class Category
    {
        [Key] // Since the key name (CategoryCode) does not include
              // "Id", we have to use an annotation (could also
              // specify this using FluitAPI)
        [MaxLength(15)]
        public string CategoryCode { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; } = null!;
        public List<TrainerCategory>? TrainerCategories { get; set; }
    }
}