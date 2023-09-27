using System.ComponentModel.DataAnnotations;

namespace Peages.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, 
            ErrorMessage = "Value for {0} cannot exceed {1} characters or must be at least {2} characters")]
        public string? Name { get; set; }


        [Range(typeof(DateTime), "1900-01-01", "2100-12-31",
             ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Birthdate { get; set; }
    }
}
