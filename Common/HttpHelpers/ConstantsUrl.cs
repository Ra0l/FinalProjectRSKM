using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ConstantsUrl
    {
        public static string UrlBase = ConfigurationManager.AppSettings["UrlBase"];
        public static string Prefix = ConfigurationManager.AppSettings["Prefix"];
        public static string Login = ConfigurationManager.AppSettings["Login"];
        public static string Cliente = ConfigurationManager.AppSettings["Cliente"];
        public static string Producto = ConfigurationManager.AppSettings["Producto"];
        public static string Vendedor = ConfigurationManager.AppSettings["Vendedor"];
        public static string Factura = ConfigurationManager.AppSettings["Factura"];
        public static string FacturaDetalle = ConfigurationManager.AppSettings["FacturaDetalle"];

    }
}
