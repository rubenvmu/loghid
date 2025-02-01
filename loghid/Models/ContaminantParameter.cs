// Models/ContaminantParameter.cs
using System.ComponentModel.DataAnnotations;

namespace loghid.Models
{
    public class ContaminantParameter
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(150)]
        public required string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public required string MaxLimit { get; set; }  // Ej: "<5 ppm"
        
        [Required]
        [StringLength(100)]
        public required string Origin { get; set; }
    }
}