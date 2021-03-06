﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FacturaDetalle
    {
        public int FacturaDetalleID { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Quantity { get; set; }

        public int FacturaID { get; set; }

        public bool State { get; set; }

        public int ProductoID { get; set; }

        public virtual Producto Producto { get; set; }

        [JsonIgnore]
        public virtual Factura Factura { get; set; }

    }
}
