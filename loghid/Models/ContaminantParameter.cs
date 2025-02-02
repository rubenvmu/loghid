using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace loghid.Models
{
    // Implementa la interfaz IEnumerable
    public class ContaminantParameter : IEnumerable<ContaminantParameter>
    {
        [Key]
        public int Id { get; set; }

        public int? ContaminantParameterId { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string MaxLimit { get; set; } = "";

        [Required]
        public string Origin { get; set; } = "";

        // Colección de contaminantes (esto es opcional, si quieres que ContaminantParameter contenga otros ContaminantParameter)
        public List<ContaminantParameter> Contaminants { get; set; } = new List<ContaminantParameter>();

        // Implementación de GetEnumerator para IEnumerable<ContaminantParameter>
        public IEnumerator<ContaminantParameter> GetEnumerator()
        {
            return Contaminants.GetEnumerator();
        }

        // Necesario para la compatibilidad con versiones antiguas de C#
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Método adicional para agregar un contaminante (si lo necesitas)
        public void AddContaminant(ContaminantParameter contaminant)
        {
            Contaminants.Add(contaminant);
        }
    }
}