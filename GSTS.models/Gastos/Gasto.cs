using System;
using System.Collections.Generic;
using System.Text;

namespace GSTS.models.Gastos
{
    public class Gasto
    {
        public int Id { get; set; }
        public int? TipoGastoId { get; set; }
        public virtual TipoGasto TipoGasto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
    }
}
