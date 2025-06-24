using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public string Url { get; set; }
        public bool Leido { get; set; }
    }

}
