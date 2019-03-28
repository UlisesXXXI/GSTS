using GSTS.models.Gastos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace GSTS.BaseDeDatos.ModelsConfiguration
{
    public class TipoGastoConfiguration:EntityTypeConfiguration<TipoGasto>
    {
        public TipoGastoConfiguration()
        {
            //Nombre tabla
            this.ToTable("TipoGasto");
            //key
            this.HasKey(x => x.Id);

            //configuracion propiedades
            this.Property(x => x.Description).HasMaxLength(50);

        }
    }
}
