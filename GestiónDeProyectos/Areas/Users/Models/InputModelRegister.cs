using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo email es obligatorio")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "El mail ingresado no es una dirección válida")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
