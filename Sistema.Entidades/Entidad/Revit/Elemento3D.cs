using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sistema.Entidades.Entidad.Revit
{
    public class Elemento3D
    {
        [JsonPropertyName("idElemento")]
        public int IdElemento { get; set; }

        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }

        [JsonPropertyName("categoria")]
        public string Categoria { get; set; }

        [JsonPropertyName("empresa")]
        public string Empresa { get; set; }

        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }

        [JsonPropertyName("proyecto")]
        public string Proyecto { get; set; }

        [JsonPropertyName("estado")]
        public string Estado { get; set; }

        [JsonPropertyName("material")]
        public MaterialInfo Material { get; set; }

        [JsonPropertyName("vertices")]
        public List<Punto3D> Vertices { get; set; }

        [JsonPropertyName("caras")]
        public List<Caras3D> Caras { get; set; }

        [JsonPropertyName("fechaRegistro")]
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
       
        [JsonPropertyName("fechaModificacion")]
        public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;

        public Elemento3D()
        {
            Vertices = new List<Punto3D>();
            Caras = new List<Caras3D>();
            Material = new MaterialInfo();
        }
    }


    public class MaterialInfo
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        public MaterialInfo()
        {
            Nombre = "Desconocido";
            Color = "#FFFFFF"; // Blanco por defecto
        }
    }


    public class Punto3D
    {
        [JsonPropertyName("idElemento")]
        public int IdElemento { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("z")]
        public double Z { get; set; }

        public Punto3D() { }

        public Punto3D(int idElemento, double x, double y, double z)
        {
            IdElemento = idElemento;
            X = x;
            Y = y;
            Z = z;
        }
    }


    public class Caras3D
    {
        [JsonPropertyName("idElemento")]
        public int IdElemento { get; set; }

        [JsonPropertyName("x1")]
        public double X1 { get; set; }

        [JsonPropertyName("y1")]
        public double Y1 { get; set; }

        [JsonPropertyName("z1")]
        public double Z1 { get; set; }

        [JsonPropertyName("x2")]
        public double X2 { get; set; }

        [JsonPropertyName("y2")]
        public double Y2 { get; set; }

        [JsonPropertyName("z2")]
        public double Z2 { get; set; }

        [JsonPropertyName("x3")]
        public double X3 { get; set; }

        [JsonPropertyName("y3")]
        public double Y3 { get; set; }

        [JsonPropertyName("z3")]
        public double Z3 { get; set; }

        public Caras3D() { }

        public Caras3D(int idElemento, double x1, double y1, double z1,
                       double x2, double y2, double z2,
                       double x3, double y3, double z3)
        {
            IdElemento = idElemento;
            X1 = x1; Y1 = y1; Z1 = z1;
            X2 = x2; Y2 = y2; Z2 = z2;
            X3 = x3; Y3 = y3; Z3 = z3;
        }
    }


}
