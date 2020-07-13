using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Stock { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public Decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public DateTime CreateAt { get; set; }

        public bool State { get; set; }

        [JsonIgnore]
        public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; }
    
}
}
