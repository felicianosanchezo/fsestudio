using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public class FsEstudioDTO
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Clabe { get; set; }
        public string Banco { get; set; }
        public string Beneficiario { get; set; }
        public string Horario { get; set; }
        public string WebLink { get; set; }
        public string Web { get; set; }
        public string Logotipo { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Cupon1 { get; set; }
        public string Cupon2 { get; set; }
        public double Marketing { get; set; }
        public double Porcentaje_Anticipo { get; set; }
        public double Porcentaje_Finiquito { get; set; }
        public double Limite_Pago { get; set; }
        public string WhatsApp { get; set; }
        public string WhatsAppTelefono { get; set; }
        public string TikTok { get; set; }



        public FsEstudioDTO(string nombre, string telefono, string correo, string direccion, string ciudad, string estado, string CLABE, string banco, string beneficiario, string horario, string weblink, string logotipo, string web, string facebook, string instagram, string cupon1, string cupon2, double marketing, double porcertaje_anticipo, double porcertaje_finiquito, double limite_pago, string whatsapp , string whatsapptelefono, string tikTok)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Ciudad = ciudad;
            Estado = estado;
            Clabe = CLABE;
            Banco = banco;
            Beneficiario = beneficiario;
            Horario = horario;
            WebLink = weblink;
            Logotipo = logotipo;
            Web = web;
            Facebook = facebook;
            Instagram = instagram;
            Cupon1 = cupon1;
            Cupon2 = cupon2;
            Marketing = marketing;
            Porcentaje_Anticipo = porcertaje_anticipo;
            Porcentaje_Finiquito = porcertaje_finiquito;
            Limite_Pago = limite_pago;
            WhatsApp = whatsapp;
            WhatsAppTelefono = whatsapptelefono;
            TikTok = tikTok;
        }
    }

    public static class FsEstudioService
    {
        public static List<FsEstudioDTO> ObtenerInformacionEmpresa()
        {
            return new List<FsEstudioDTO>
            {
                new FsEstudioDTO(
                   nombre: "FS Estudio",
                   telefono: "+52 6624 65 19 04",
                   correo: "contacto@fsestudio.com",
                   direccion: "Av. Tepache 657 Col.Primero Hermosillo CP 83116",
                   ciudad: "Hermosillo",
                   estado: "Sonora",
                   CLABE: "661610001894750019",
                   banco:"Klar",
                   beneficiario:"Feliciano Sanchez Ortega",
                   horario:"Lunes a Viernes de 8:00 am - 5:00 pm",
                   weblink:"https://fsestudio.com",
                   logotipo:"https://fsalmacenamiento.blob.core.windows.net/fsestudiocontenedor/Logo1.%20Fondo%20Blanco.png",
                   web:"www.fsestudio.com",
                   facebook:"https://www.facebook.com/FS.Estudio.Arquitectura",
                   instagram:"https://www.instagram.com/fsestudiio",
                   cupon1:"PRIMER-SERVICIO-15%",
                   cupon2:"BLACKFRIDAY2024",
                   marketing: 1.15,
                   porcertaje_anticipo: 0.6,
                   porcertaje_finiquito: 0.4,
                limite_pago: 15000.00,
                   whatsapp:"https://wa.me/5216624651904",
                   whatsapptelefono:"5216624651904",

                   tikTok:"https://www.tiktok.com/@fsestudioarquitecura"





                )
            };
        }
    }
}
