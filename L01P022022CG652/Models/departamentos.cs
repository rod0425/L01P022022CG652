using System.ComponentModel.DataAnnotations;

namespace L01P022022CG652.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]
        [Display(Name = "Departamento")]
        public string departamento { get; set; }
    }
}
