using Sistema.Entidades.Entidad.WMoveit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.WMoveitDto
{
    public static class UtilidadesDto
    {
        public static WMoveitLoginUsuarioDto ConvertirDto(WMoveitLoginUsuario u)
        {
            if (u != null)
            {
                return new WMoveitLoginUsuarioDto
                {
                    Token = u.Token,
                    Rol = u.Rol,
                    Nombre = u.Nombre,
                    Correo = u.Correo,
                    IdUsuario = u.IdUsuario
                };
            }

            return null;
        }
    }
}
