namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string? Nombre { get; set; } = null!;

        public string? Apellidos { get; set; } = null!;

        public string? Rol { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public string? Usuario_Sesion { get; set; } = null!;

        public string Password { get; set; } = null!;
        public bool? Estado { get; set; } = true;
        public string? Estado_Region { get; set; } = null!;
        public string? Ciudad { get; set; } = null!;
        public string? Direccion { get; set; } = null!;

        public string? Nombre_Publico { get; set; } = null!;
        public string? Foto_Perfil { get; set; } = null!;
        public DateTime Fecha_Creacion { get; set; } // Fecha de creación de la venta
        public bool Terminos_Generales { get; set; }

        public string? Version_Terminos_Aceptados { get; set; }
        public string? Terminos_Generales_Aceptados { get; set; }


        public DateTime? Fecha_Terminos { get; set; } // Fecha de creación de la venta




        public string? NumeroUsuario { get; set; } // Campo para el número de orden










    }
}
