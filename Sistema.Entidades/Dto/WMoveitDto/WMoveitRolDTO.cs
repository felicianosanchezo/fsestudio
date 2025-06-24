using System.Collections.Generic;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public class WMoveitRolDTO
    {
        public string Nombre { get; set; }

        public WMoveitRolDTO(string nombre)
        {
            Nombre = nombre;
        }
    }



    public static class WMoveiRolService
    {
        public static List<WMoveitRolDTO> ObtenerRoles()
        {
            return new List<WMoveitRolDTO>
            {
                new WMoveitRolDTO("Administrador"),
                new WMoveitRolDTO("Usuario Básico"),
            };
        }
    }
}
