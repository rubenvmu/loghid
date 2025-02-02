using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace loghid.Models
{
    // Implementa la interfaz IEnumerable
    public class IdealParameter : IEnumerable<IdealParameter>
    {
        [Key]
        public int Id { get; set; }

        public int? IdealParameterId { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public decimal Value { get; set; }

        [Required]
        public string Origin { get; set; } = "";

        // Colección de parámetros ideales (esto es opcional, si quieres que IdealParameter contenga otros IdealParameter)
        public List<IdealParameter> IdealParameters { get; set; } = new List<IdealParameter>();

        // Implementación de GetEnumerator para IEnumerable<IdealParameter>
        public IEnumerator<IdealParameter> GetEnumerator()
        {
            return IdealParameters.GetEnumerator();
        }

        // Necesario para la compatibilidad con versiones antiguas de C#
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Método adicional para agregar un parámetro ideal (si lo necesitas)
        public void AddIdealParameter(IdealParameter idealParameter)
        {
            IdealParameters.Add(idealParameter);
        }
    }
}