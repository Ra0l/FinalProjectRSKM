using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.HttoHelpers
{
    public class ApiUrl
    {
        public static string Url(int model)
        {
            string url = BaseUrl() + modelUrl(model);
            return url;
        }

        public static string BaseUrl()
        {
            string url = ConfigurationManager.AppSettings["Url"];
            string port = ConfigurationManager.AppSettings["Port"];
            string api = ConfigurationManager.AppSettings["Api"];
            string baseUrl = url + port + api;

            return baseUrl;
        }

        public static string modelUrl(int model)
        {
            string modelUrl = "";
            switch (model)
            {
                case (int)Numerable.Cliente:
                    modelUrl = ConfigurationManager.AppSettings["Cliente"];
                    break;
                case (int)Numerable.Producto:
                    modelUrl = ConfigurationManager.AppSettings["Producto"];
                    break;
                case (int)Numerable.Factura:
                    modelUrl = ConfigurationManager.AppSettings["Factura"];
                    break;
                case (int)Numerable.FacturaDetalle:
                    modelUrl = ConfigurationManager.AppSettings["FacturaDetalle"];
                    break;
                case (int)Numerable.Vendedor:
                    modelUrl = ConfigurationManager.AppSettings["Vendedor"];
                    break;
                default:
                    break;
            }

            return modelUrl;
        }


    
}
}
