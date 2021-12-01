using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Models
{
    public class Tarea
    {
        [Key]
        public int codTarea { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe Ingresar el Título.")]
        public string Titulo { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Descripcion { get; set; }

        [Display(Name = "Grado de Avance")]
        public string GradoDeAvance { get; set; }

        public float Duracion { get; set; }

        public virtual ICollection<TareaRecurso> TareasRecurso { get; set; }

        public int? ProyectoId { get; set; }
        [ForeignKey("ProyectoId")]
        public virtual Proyecto Proyecto { get; set; }


    }
}
