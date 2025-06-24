using Sistema.Entidades.Entidad.FsEstudio;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sistema.Entidades.Dto.FsEstudio
{
    public static class Utilidades
    {
        public static LoginUsuarioDTO convertirDTO(this LoginUsuario u)
        {
            if (u != null)
            {
                return new LoginUsuarioDTO
                {
                    Token = u.Token,
                    Rol = u.Rol,
                    Nombre = u.Nombre,
                    Nombre_Publico = u.Nombre_Publico,
                    Email = u.Email,
                    Usuario = u.Usuario,
                    IdUsuario = u.IdUsuario
                };
            }

            return null;
        }
        public static UsuarioDTO convertirDTO(this Usuario e)
        {
            if (e != null)
            {
                return new UsuarioDTO
                {
                    IdUsuario = e.IdUsuario,
                    Nombre = e.Nombre,
                    Apellidos = e.Apellidos,
                    Telefono = e.Telefono,
                    Email = e.Email,
                    tipoUsuario = e.Rol.ToString(),
                    Usuario = e.Usuario_Sesion,
                    Password = e.Password,
                    Estado = e.Estado,
                    Estado_Region = e.Estado_Region,
                    Direccion = e.Direccion,
                    Ciudad = e.Ciudad,
                    Nombre_Publico = e.Nombre_Publico,
                    Foto_Perfil = e.Foto_Perfil,
                    Terminos_Generales = e.Terminos_Generales,
                    Fecha_Creacion = e.Fecha_Creacion,
                    Version_Terminos_Aceptados = e.Version_Terminos_Aceptados,
                    Terminos_Generales_Aceptados = e.Terminos_Generales_Aceptados,
                    Fecha_Terminos = e.Fecha_Terminos,
                    NumeroUsuario = e.NumeroUsuario




                };
            }

            return null;
        }
        public static MaterialDTO convertirDTO(this Material e)
        {
            if (e != null)
            {
                return new MaterialDTO
                {
                    IdMaterial = e.IdMaterial,
                    Clave = e.Clave,
                    Categoria = e.Categoria,
                    IdUsuario = e.IdUsuario,
                    Descripcion = e.Descripcion,
                    Unidad = e.Unidad,
                    Precio = e.Precio,
                    Iva = e.Iva,
                    Estado = e.Estado,
                    Tipo = e.Tipo,
                    Marca = e.Marca,
                    Fecha = e.Fecha,
                    Usuario = e.Usuario
                };
            }

            return null;
        }
        public static MaterialCategoriaDTO convertirDTO(this MaterialCategoria e)
        {
            if (e != null)
            {
                return new MaterialCategoriaDTO
                {
                    Nombre = e.Nombre,
                };
            }

            return null;
        }
        public static CuentaDTO convertirDTO(this Cuenta cuenta)
        {
            if (cuenta != null)
            {
                return new CuentaDTO
                {
                    IdCuenta = cuenta.IdCuenta,
                    Nombre = cuenta.Nombre,
                    Descripcion = cuenta.Descripcion,
                    Estado = cuenta.Estado,
                    Porcentaje = cuenta.Porcentaje,
                    Orden = cuenta.Orden,
                    IdUsuario = cuenta.IdUsuario,
                    Panel = cuenta.Panel
                };
            }

            return null;
        }
        public static CarteraDTO ConvertirDTO(this Cartera cartera)
        {
            return new CarteraDTO
            {
                IdCartera = cartera.IdCartera,
                Nombre = cartera.Nombre,
                Descripcion = cartera.Descripcion,
                Estado = cartera.Estado,
                Orden = cartera.Orden,
                IdUsuario = cartera.IdUsuario,
                Tipo = cartera.Tipo
            };
        }

        public static CategoriaDTO ConvertirDTO(this Categoria categoria)
        {
            return new CategoriaDTO
            {
                IdCategoria = categoria.IdCategoria,
                Nombre = categoria.Nombre,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado,
                Operacion = categoria.Operacion,
                IdUsuario = categoria.IdUsuario
            };
        }
        public static GastoDTO convertirDTO(this Gasto gasto)
        {
            return new GastoDTO
            {
                IdGasto = gasto.IdGasto,
                IdUsuario = gasto.IdUsuario,
                Fecha = gasto.Fecha,
                Total = gasto.Total,
                IdCartera = gasto.IdCartera,
                IdCuenta = gasto.IdCuenta,
                IdCategoria = gasto.IdCategoria,
                Concepto = gasto.Concepto,
                Cuenta = gasto.Cuenta,
                Cartera = gasto.Cartera,
                Categoria = gasto.Categoria



            };
        }


        public static IngresoDTO ConvertirDTO(this Ingreso ingreso)
        {
            if (ingreso != null)
            {
                return new IngresoDTO
                {
                    IdIngreso = ingreso.IdIngreso,
                    IdUsuario = ingreso.IdUsuario,
                    Fecha = ingreso.Fecha,
                    Total = ingreso.Total,
                    IdCartera = ingreso.IdCartera,
                    IdCategoria = ingreso.IdCategoria,
                    Cartera = ingreso.Cartera,
                    Categoria = ingreso.Categoria,
                    Concepto = ingreso.Concepto,
                    IngresoDetalle = ingreso.IngresoDetalle?.Select(d => d.ConvertirDTO()).ToList()
                };
            }

            return null;
        }

        public static Ingreso_DetalleDTO ConvertirDTO(this Ingreso_Detalle detalle)
        {
            if (detalle != null)
            {
                return new Ingreso_DetalleDTO
                {
                    IdIngresoDetalle = detalle.IdIngresoDetalle,
                    IdCuenta = detalle.IdCuenta,
                    Cuenta = detalle.Cuenta,
                    Porcentaje = detalle.Porcentaje,
                    Total = detalle.Total
                };
            }

            return null;
        }


        public static ServicioDTO ConvertirDTO(this Servicio servicio)
        {
            if (servicio != null)
            {
                return new ServicioDTO
                {
                    IdServicio = servicio.IdServicio,
                    Nombre = servicio.Nombre,
                    Descripcion = servicio.Descripcion,
                    Categoria = servicio.Categoria,
                    Especificaciones = servicio.Especificaciones,
                    Estado = servicio.Estado,
                    FechaCreacion = servicio.FechaCreacion,
                    FechaModificacion = servicio.FechaModificacion,
                    IdUsuario = servicio.IdUsuario,
                    Usuario = servicio.Usuario,
                    PortadaUrl = servicio.PortadaUrl,
                    Unidad = servicio.Unidad,
                    Requisitos_Cliente = servicio.Requisitos_Cliente,
                    Entregables = servicio.Entregables,
                    Etiquetas = servicio.Etiquetas,
                    Requisitos_Colaborador = servicio.Requisitos_Colaborador,
                    Dirigido = servicio.Dirigido,
                    Garantia = servicio.Garantia,
                    Calificacion = servicio.Calificacion






                };
            }

            return null;
        }

        public static Servicio_CategoriaDTO ConvertirDTO(this Servicio_Categoria categoria)
        {
            return new Servicio_CategoriaDTO
            {
                IdCategoria = categoria.IdCategoria,
                Nombre = categoria.Nombre,
                Descripcion = categoria.Descripcion,
                IdUsuario = categoria.IdUsuario
            };
        }
        public static Servicio_ImagenesDTO ConvertirDTO(this Servicio_Imagenes imagen)
        {
            return new Servicio_ImagenesDTO
            {
                Id = imagen.Id,
                Url = imagen.Url,
                OrdenVisualizacion = imagen.OrdenVisualizacion,
                IdServicio = imagen.IdServicio
                // Añade cualquier otra propiedad que necesites convertir
            };
        }

        public static Colaborador_ServicioDTO ConvertirDTO(this Colaborador_Servicio servicio)
        {
            if (servicio != null)
            {
                return new Colaborador_ServicioDTO
                {
                    IdServicio_Colaborador = servicio.IdServicio_Colaborador,
                    IdServicio = servicio.IdServicio,
                    Precio = servicio.Precio,
                    Unidad = servicio.Unidad,
                    Duracion = servicio.Duracion,
                    Notas = servicio.Notas,
                    ArchivoUrl = servicio.ArchivoUrl,
                    VideoUrl = servicio.VideoUrl,
                    ImagenUrl1 = servicio.ImagenUrl1,
                    ImagenUrl2 = servicio.ImagenUrl2,
                    ImagenUrl3 = servicio.ImagenUrl3,
                    ImagenUrl4 = servicio.ImagenUrl4,
                    ImagenUrl5 = servicio.ImagenUrl5,
                    ImagenUrl6 = servicio.ImagenUrl6,
                    FechaCreacion = servicio.FechaCreacion,
                    FechaModificacion = servicio.FechaModificacion,
                    UrlPerfil = servicio.UrlPerfil,
                    Perfil = servicio.Perfil
                };
            }

            return null;
        }
        public static CuponDTO ConvertirDTO(this Cupon cupon)
        {

            if (cupon != null)
            {
                return new CuponDTO
                {
                    Id = cupon.Id,
                    Codigo = cupon.Codigo,
                    Descuento = cupon.Descuento,
                    FechaInicio = cupon.FechaInicio,
                    FechaExpiracion = cupon.FechaExpiracion,
                    EsActivo = cupon.EsActivo,
                    UsoMaximo = cupon.UsoMaximo,
                    UsoActual = cupon.UsoActual,
                    Descripcion = cupon.Descripcion,
                    IdVenta_Servicio = cupon.IdVenta_Servicio
                };
            }
            return null;
        }


        public static Venta_ServicioDTO ConvertirDTO(this Venta_Servicio ventaDto)
        {
            if (ventaDto != null)
            {
                return new Venta_ServicioDTO
                {

                    IdVenta_Servicio = ventaDto.IdVenta_Servicio,
                    IdUsuarioColaborador = ventaDto.IdUsuarioColaborador,
                    IdServicio = ventaDto.IdServicio,
                    IdServicio_Colaborador = ventaDto.IdServicio_Colaborador,
                    IdUsuarioComprador = ventaDto.IdUsuarioComprador,
                    NombreComprador = ventaDto.NombreComprador,
                    NombreServicio = ventaDto.NombreServicio,
                    NombreColaborador = ventaDto.NombreColaborador,
                    Cantidad = ventaDto.Cantidad,
                    Revision = ventaDto.Revision,
                    Precio = ventaDto.Precio,
                    Tiempo = ventaDto.Tiempo,
                    Importe = ventaDto.Importe,
                    Total = ventaDto.Total,
                    IdCupon = ventaDto.IdCupon,
                    FechaCreacion = ventaDto.FechaCreacion,
                    FechaPago = ventaDto.FechaPago,
                    FechaEntregaEstimada = ventaDto.FechaEntregaEstimada,
                    Estado = ventaDto.Estado,
                    MetodoPago = ventaDto.MetodoPago,
                    PagoRealizado = ventaDto.PagoRealizado,
                    Descuento = ventaDto.Descuento,
                    DescripcionServicio = ventaDto.DescripcionServicio,
                    IdTransaccion = ventaDto.IdTransaccion,
                    ClientSecret = ventaDto.ClientSecret,
                    MetodoEntrega = ventaDto.MetodoEntrega,
                    NumeroOrden = ventaDto.NumeroOrden,
                    TerminosAceptados = ventaDto.TerminosAceptados,
                    VersionTerminosServicio = ventaDto.VersionTerminosServicio,
                    EspecificacionesAceptados = ventaDto.EspecificacionesAceptados,
                    EntregablesAceptados = ventaDto.EntregablesAceptados,
                    RequisitosAceptados = ventaDto.RequisitosAceptados



                };
            }

            return null;
        }










        public static string? GetImagenOriginal(Colaborador_ServicioDTO servicioColaboradorOriginal, int imagenId)
        {
            return imagenId switch
            {
                1 => servicioColaboradorOriginal.ImagenUrl1,
                2 => servicioColaboradorOriginal.ImagenUrl2,
                3 => servicioColaboradorOriginal.ImagenUrl3,
                4 => servicioColaboradorOriginal.ImagenUrl4,
                5 => servicioColaboradorOriginal.ImagenUrl5,
                6 => servicioColaboradorOriginal.ImagenUrl6,
                _ => null
            };
        }





        ///////////
        ///
        public static ServicioBaseDTO ConvertirDTO(this ServicioBase servicio)
        {
            if (servicio != null)
            {
                return new ServicioBaseDTO
                {
                    IdServicio = servicio.IdServicio,
                    Codigo = servicio.Codigo,
                    Nombre = servicio.Nombre,
                    Descripcion = servicio.Descripcion,
                    Capitulo = servicio.Capitulo,
                    Categoria = servicio.Categoria,
                    Tipo = servicio.Tipo,
                    Unidad = servicio.Unidad,
                    AplicaPorM2 = servicio.AplicaPorM2,
                    Nivel = servicio.Nivel,
                    PortadaUrl = servicio.PortadaUrl,
                    Activo = servicio.Activo
                };
            }

            return null;
        }



        public static PortafolioDTO ConvertirDTO(this Portafolio entidad)
        {
            if (entidad != null)
            {
                return new PortafolioDTO
                {
                    IdPortafolio = entidad.IdPortafolio, // Asumiendo que así se llama en la entidad
                    Nombre = entidad.Nombre,
                    Descripcion = entidad.Descripcion,
                    Areas = entidad.Areas,
                    Categoria = entidad.Categoria,
                    Ubicacion = entidad.Ubicacion,
                    Fecha = entidad.Fecha,
                    SuperficieConstruidaM2 = entidad.SuperficieConstruidaM2,
                    SuperficieTerrenoM2 = entidad.SuperficieTerrenoM2,
                    FueConstruido = entidad.FueConstruido,
                    PortadaUrl = entidad.PortadaUrl,
                    Imagen1Url = entidad.Imagen1Url,
                    Imagen2Url = entidad.Imagen2Url,
                    Imagen3Url = entidad.Imagen3Url,
                    Imagen4Url = entidad.Imagen4Url,
                    Imagen5Url = entidad.Imagen5Url,
                    Imagen6Url = entidad.Imagen6Url,
                    Activo = entidad.Activo,
                    Orden = entidad.Orden
                };
            }

            return null;
        }

    }
}
