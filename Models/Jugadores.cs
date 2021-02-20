using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Models
{
    public class Jugadores
    {

        [Display(Name = "Club")]
        [Required]
        public string Club { get; set; }
        [Display(Name = "Posicion")]
        [Required]
        public string Pos { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string Surname { get; set; }
        [Display(Name = "Salary")]
        [Required]
        public int? Salary { get; set; }


    }
}
