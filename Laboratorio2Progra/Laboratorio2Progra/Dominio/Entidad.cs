using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2Progra.Dominio
{
    public class Entidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }


        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "C")]
        public string NombrePersona { get; set; }



        [Display(Name = "Edad")]
        [Required(ErrorMessage = "C")]
        [Range(18, int.MaxValue, ErrorMessage = "Es")]
        public int EdadPersona { get; set; }


        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ca")]
        public string DescripcionPersona { get; set; }
    }
}
