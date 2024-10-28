using GAVILANESJOHAO_EXA.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAVILANESJOHAO_EXAMEN.Models
{
    public class EGavilanes
    {

        [Key]

        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        
        public int cedula { get; set; }
        
        public float peso { get; set; }
        public bool NacionalEcuatoriano { get; set; }

        public Celular? Celular { get; set; }

        [ForeignKey("Celular")]
        public int IdCelular { get; set; }


    }
}