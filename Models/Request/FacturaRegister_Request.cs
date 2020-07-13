using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    public class FacturaRegister_Request
    {
        public Factura_Request Factura { get; set; }
        public List<FacturaDetalle_Request> FacturaDetalles { get; set; }

    }
}
