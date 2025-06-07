using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expanse_tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = " ";
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = " Expense";
    }
}
