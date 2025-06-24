using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class UsuarioDTO
    {

        [Display(Name = "ID de Usuario")]
        public int IdUsuario { get; set; }



        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres.")]
        public string Nombre { get; set; } = null!;



        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres.")]
        public string Apellidos { get; set; } = null!;



        public string? tipoUsuario { get; set; } = null!;



        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Phone(ErrorMessage = "El campo {0} debe contener un número de teléfono válido.")]
        public string Telefono { get; set; } = null!;



        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debes ingresar un correo válido en el campo {0}.")]
        public string Email { get; set; } = null!;



        [Display(Name = "Nombre de usuario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Usuario { get; set; } = null!;



        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres.")]
        public string Password { get; set; } = null!;



        [Display(Name = "Estado")]
        public bool? Estado { get; set; } = true;



        [Display(Name = "Estado o Región")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Estado_Region { get; set; } = null!;



        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Ciudad { get; set; } = null!;


        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Direccion { get; set; } = null!;




        [Display(Name = "Nombre Publico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Nombre_Publico { get; set; } = null!;



        [Display(Name = "Foto de Perfil")]

        public string? Foto_Perfil { get; set; } = null!;




        [Display(Name = "Términos generales")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public bool Terminos_Generales { get; set; } // Cambiado de bool? a bool



        public DateTime? Fecha_Creacion { get; set; } // Fecha de creación de la venta

        public string? Version_Terminos_Aceptados { get; set; }
        public string? Terminos_Generales_Aceptados { get; set; }
        public DateTime? Fecha_Terminos { get; set; } // Fecha de creación de la venta


        public string? NumeroUsuario { get; set; } // Campo para el número de orden



    }
}
