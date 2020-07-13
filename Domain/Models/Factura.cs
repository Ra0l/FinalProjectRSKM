using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Factura
    {
        [Key]
        public int FacturaID { get; set; }

        public string Number { get; set; }

        public bool Payed { get; set; }

        public int discount { get; set; }

        public string Reason { get; set; }

        public DateTime CreateAt { get; set; }

        public bool State { get; set; }

        public int ClienteID { get; set; }

        public int VendedorID { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; }

    }
}
