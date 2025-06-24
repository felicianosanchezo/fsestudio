using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{

        public class WMoveitLoginDto
        {
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            // [EmailAddress(ErrorMessage = "Debes ingresar un correo válido.")]
            public string Correo { get; set; } = null!;

            [Display(Name = "Contraseña")]
            [Required(ErrorMessage = "El campo {0} es obligatorio.")]
            // [MinLength(6, ErrorMessage = "El campo {0} debe tener al menos {1} carácteres.")]
            public string Contraseña { get; set; } = null!;
    }

}



