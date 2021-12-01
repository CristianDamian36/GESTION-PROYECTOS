using GestiónDeProyectos.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Models
{
    public class Recurso
    {
        [Key]
        public int LegajoEmp { get; set; }

        
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe Ingresar el Nombre.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe Ingresar el Apellido.")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Display(Name = "DNI")]
        public int dni { get; set; }

         public int? RolId { get; set; }
        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }

        public virtual ICollection<TareaRecurso> TareasRecurso { get; set; }

    }


}
