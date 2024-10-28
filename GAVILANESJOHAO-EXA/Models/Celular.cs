using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GAVILANESJOHAO_EXAMEN.Models
{
    public class Celular
    {
        [Key]
        public int IdCelular { get; set; }
        [Required]
        [StringLength(1024)]
        [DisplayName("Modelo")]
        public string NombreModelo { get; set; }
        [Required]
        public int año { get; set; }
        
        public float precio { get; set; }

    }
}