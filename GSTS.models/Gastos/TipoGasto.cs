using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GSTS.models.Gastos
{
    public class TipoGasto
    {
        #region Constructor
        public TipoGasto()
        {
            Gastos = new List<Gasto>();
        }
        #endregion

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
