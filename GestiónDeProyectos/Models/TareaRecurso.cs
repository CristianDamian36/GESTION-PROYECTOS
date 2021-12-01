using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Models
{
    public class TareaRecurso
    {
        [Key]
        public int IdTabla_Recurso { get; set; }

        public int TareaId { get; set; }
        public virtual Tarea Tarea { get; set; }
        public int RecursoId { get; set; }
        public virtual Recurso Recurso { get; set; }
    }
}
