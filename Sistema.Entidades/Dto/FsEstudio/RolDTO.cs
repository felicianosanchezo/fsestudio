using System.Collections.Generic;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class RolDTO
    {
        public string Nombre { get; set; }

        public RolDTO(string nombre)
        {
            Nombre = nombre;
        }
    }



    public static class RolService
    {
        public static List<RolDTO> ObtenerRoles()
        {
            return new List<RolDTO>
            {
                new RolDTO("Administrador"),
                new RolDTO("Usuario Básico"),
                new RolDTO("Freelancer"),
                new RolDTO("Especialista en Marketing"),
                new RolDTO("Inversionista"),
                new RolDTO("Project Manager"),
                new RolDTO("Desarrollador"),
                new RolDTO("Cliente Premium")
            };
        }
    }
}
