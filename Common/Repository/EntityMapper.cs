using AutoMapper;
using Common.HttoHelpers;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public class EntityMapper<TSource, TDestination> where TSource : class where TDestination : class
    {
        Mapper.CreateMap<EResponseBase<Producto>, EResponseBase<Producto_Response>>();
            Mapper.CreateMap<EResponseBase<Producto_Response>, EResponseBase<Producto>>();
            Mapper.CreateMap<EResponseBase<Producto_Request>, EResponseBase<Producto>>();

            Mapper.CreateMap<EResponseBase<Cliente>, EResponseBase<Cliente_Response>>();
            Mapper.CreateMap<EResponseBase<Cliente_Response>, EResponseBase<Cliente>>();
            Mapper.CreateMap<EResponseBase<Cliente_Request>, EResponseBase<Cliente>>();

            Mapper.CreateMap<Factura, Factura_Response>();
            Mapper.CreateMap<Factura_Response, Factura>();
            Mapper.CreateMap<Factura_Request, Factura>();

            Mapper.CreateMap<FacturaDetalle, FacturaDetalle_Response>();
            Mapper.CreateMap<FacturaDetalle_Response, FacturaDetalle>();
            Mapper.CreateMap<FacturaDetalle_Request, FacturaDetalle>();

            Mapper.CreateMap<Vendedor, Vendedor_Response>();
            Mapper.CreateMap<Vendedor_Response, Vendedor>();
            Mapper.CreateMap<Vendedor_Request, Vendedor>();

        }

    public TDestination Translate(TSource obj)
    {
        return Mapper.Map<TDestination>(obj);
    }
}
}
