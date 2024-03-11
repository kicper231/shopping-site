using System.ComponentModel.DataAnnotations;

namespace RazorDotnetMastery.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "In range(0, 100)")]
        public int DisplayOrder { get; set; }


    }
}
