using System.ComponentModel.DataAnnotations;

namespace L01P022022CG652.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "ID")]
        public string codigo { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string apellidos { get; set; }
        [Required]
        [Display(Name = "DUI")]
        public int dui { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public int estado { get; set; }
    }
}
