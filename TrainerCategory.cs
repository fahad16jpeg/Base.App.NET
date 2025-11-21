using System.ComponentModel.DataAnnotations;
using Vista.app.Data;
namespace Vista.App.Data
{
    public class TrainerCategory
    {
        // Has a composite (compound) key that will be defined TrainersDbConext
        [Required]
        public int TrainerId { get; set; }
        [Required]
        [MaxLength(15)]
        public string CategoryCode { get; set; } = null!;
        public Trainer? Trainer { get; set; }
        // See TrainersDbConext for Foreign Key (Fluent API) definition
        public Category? Category { get; set; }

    }
}
