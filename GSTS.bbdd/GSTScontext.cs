using GSTS.bbdd.ModelsConfiguration;
using GSTS.models.Gastos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace GSTS.bbdd
{
    public class GSTScontext:DbContext
    {
        #region DbSet`s
        public DbSet<TipoGasto> TipoGasto { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        #endregion
        #region Constructor
        public GSTScontext() : base("DefaultConnection")
        {

        }
        #endregion
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
           CargarConfiguracionesModelos(ref modelBuilder);

        }

        public void CargarConfiguracionesModelos(ref DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new TipoGastoConfiguration());
            modelBuilder.Configurations.Add(new GastoConfiguracion());
        }
    }
}
