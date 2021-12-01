using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Descripcion { get; set; }

        public float Costo { get; set; }

    }
}
