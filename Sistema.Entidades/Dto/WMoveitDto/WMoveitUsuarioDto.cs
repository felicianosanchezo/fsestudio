using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitUsuarioDto
    {
        [Display(Name = "ID de Usuario")]
        public int IdUsuario { get; set; } // ID único, mapeado con ID_Usuario en la tabla

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres.")]
        public string Nombre { get; set; } = null!; // Mapeado con Nombre en la tabla

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres.")]
        public string Apellidos { get; set; } = null!; // Mapeado con Apellidos en la tabla

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debes ingresar un correo válido en el campo {0}.")]
        [MaxLength(150, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres.")]
        public string Correo { get; set; } = null!; // Mapeado con Correo en la tabla

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres.")]
        public string Contrasena { get; set; } = null!; // Mapeado con Contraseña en la tabla

        [Display(Name = "Estado")]
        public bool? Estado { get; set; } = true; // Activo/Inactivo, mapeado con Estado en la tabla

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; } // Mapeado con Fecha_Registro en la tabla

        [Display(Name = "Rol")]
        public string? Rol { get; set; } = null!; // Mapeado con Rol en la tabla

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Phone(ErrorMessage = "El campo {0} debe contener un número de teléfono válido.")]
        public string? Telefono { get; set; } = null!; // Mapeado con Telefono en la tabla

        [Display(Name = "Instructor")]
        public bool EsInstructor { get; set; } // Indica si el usuario es instructor

        [Display(Name = "ID del Paquete")]
        public int IdPaquete { get; set; } // ID del paquete, mapeado con IdPaquete en la tabla

        [Display(Name = "Nombre del Paquete")]
        public string? Paquete { get; set; } = null!; // Nombre del paquete, obtenido de la tabla Paquetes





    }

}
