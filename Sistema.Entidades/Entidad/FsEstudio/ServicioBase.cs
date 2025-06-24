using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Entidad.FsEstudio
{
    public class ServicioBase
    {



        public int IdServicio { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Nivel { get; set; }
        public string Capitulo { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Unidad { get; set; }
        public bool AplicaPorM2 { get; set; }
        public bool Activo { get; set; }
        public string? PortadaUrl { get; set; } // URL de la imagen de portada del servicio
        public DateTime Fecha { get; set; } = DateTime.Today;


    }
}
