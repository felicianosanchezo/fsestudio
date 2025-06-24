using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.WMoveit
{

    public class WMoveitUsuario
    {
        public int IdUsuario { get; set; } // Columna ID_Usuario

        public string Nombre { get; set; } = null!; // Columna Nombre

        public string Apellidos { get; set; } = null!; // Columna Apellidos

        public string Correo { get; set; } = null!; // Columna Correo

        public string Contraseña { get; set; } = null!; // Columna Contraseña

        public bool Estado { get; set; } = true; // Columna Estado (true = Activo, false = Inactivo)

        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow; // Columna Fecha_Registro con valor predeterminado

        public string? Rol { get; set; } = null!; // Columna Rol

        public string? Telefono { get; set; } // Columna Telefono

        public bool EsInstructor { get; set; } // Columna Instructor (true/false)

        public int IdPaquete { get; set; } // Columna IdPaquete (relación con la tabla Paquetes)

        public string? Paquete { get; set; } // Nombre del paquete, obtenido de la tabla Paquetes


        public DateTime? FechaActivacion { get; set; } // Fecha en la que se activó el usuario
        public DateTime? FechaVigencia { get; set; } // Fecha hasta la que el usuario tiene vigencia
        public int? DuracionVigenciaMeses { get; set; } // Duración de la vigencia en meses


        public int ClasesAsignadas { get; set; }    // Clases asignadas por el paquete
        public int ClasesReservadas { get; set; }   // Clases reservadas activas
        public int ClasesCanceladas { get; set; }   // Clases canceladas
        public int ClasesPendientes { get; set; }   // Clases pendientes



    }






}
