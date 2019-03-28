using GSTS.models.Gastos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GSTS.ViewModel
{
    public class GastosViewModel
    {
        public int Id { get; set; }

        public int? TipoGastoId { get; set; }
        public virtual TipoGasto TipoGasto { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public decimal Importe { get; set; }
        

    }
}