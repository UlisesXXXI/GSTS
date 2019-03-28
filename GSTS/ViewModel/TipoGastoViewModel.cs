using GSTS.models.Gastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTS.ViewModel
{
    public class TipoGastoViewModel
    {
        #region Constructor
        public TipoGastoViewModel()
        {
            Gastos = new List<Gasto>();
        }
        #endregion

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}