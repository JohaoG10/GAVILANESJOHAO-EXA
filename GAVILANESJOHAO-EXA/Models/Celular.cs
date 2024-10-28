using System.ComponentModel.DataAnnotations;

namespace GAVILANESJOHAO_EXAMEN.Models
{
    public class Celular
    {
        [Key]
        public int IdCelular { get; set; }
        [Required]
        
        public string NombreModelo { get; set; }
        [Required]
        public int año { get; set; }
        
        public float precio { get; set; }

    }
}