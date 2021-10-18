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
        [Required(ErrorMessage = "Campo requerido")]
        public string NombrePersona { get; set; }



        [Display(Name = "Edad")]
        [Range(18, int.MaxValue, ErrorMessage = "Debe ser mayor de edad")]
        public int EdadPersona { get; set; }


        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Campo requerido")]
        public string DescripcionPersona { get; set; }
    }
}
