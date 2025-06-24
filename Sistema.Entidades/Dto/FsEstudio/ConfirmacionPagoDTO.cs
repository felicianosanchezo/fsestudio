using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class ConfirmacionPagoDTO
    {
        public string ClientSecret { get; set; }
        public decimal Monto { get; set; }
        public string DescripcionServicio { get; set; }
    }
}
