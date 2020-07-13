using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    public class FacturaDetalle_Request
    {
        public int FacturaDetalleID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        public int FacturaID { get; set; }
        public int ProductoID { get; set; }

    }
}
