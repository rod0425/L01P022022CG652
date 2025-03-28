using System.ComponentModel.DataAnnotations;

namespace L01P022022CG652.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]
        [Display(Name = "Materia")]
        public string materia { get; set; }
        [Required]
        [Display(Name = "Unidades Valorativas")]
        public int unidades_valorativas { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public char estado { get; set; }
    }
}
