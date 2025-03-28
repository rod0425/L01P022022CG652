using System.ComponentModel.DataAnnotations;

namespace L01P022022CG652.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]
        [Display(Name = "Faculad")]
        public string facultad { get; set; }
    }
}
