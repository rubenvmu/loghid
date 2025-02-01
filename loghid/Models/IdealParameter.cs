using System.ComponentModel.DataAnnotations;

namespace loghid.Models
{
    public class IdealParameter
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(150)]
        public required string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public required string Value { get; set; }  // Ej: "≥99.97%"
        
        [Required]
        [StringLength(100)]
        public required string Origin { get; set; } // Ej: "ISO 14687:2019"
    }
}