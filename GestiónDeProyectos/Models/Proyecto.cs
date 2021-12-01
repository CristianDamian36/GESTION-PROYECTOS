using GestiónDeProyectos.Data;
using GestiónDeProyectos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Models
{
    public class Proyecto
    {

        [Key]
        public int codProyecto { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe Ingresar el Título.")]
        public string Titulo { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Descripcion { get; set; }

        [Column(TypeName = "DateTime2")]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "DateTime2")]
        [Display(Name = "Fecha de Entrega")]
        public DateTime FechaEntrega { get; set; }

        [Display(Name = "Presupuesto Total")]
        public float PresupuestoTotal { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
 
        public int? LegajoEmp { get; set; }
        [Display(Name = "Legajo Recurso")]
        [ForeignKey("LegajoEmp")]
        public virtual Recurso Recurso { get; set; }
    }
}
