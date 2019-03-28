using GSTS.models.Gastos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace GSTS.bbdd.ModelsConfiguration
{
    //http://www.entityframeworktutorial.net/code-first/move-configurations-to-seperate-class-in-code-first.aspx

    public class GastoConfiguracion: EntityTypeConfiguration<Gasto>
    {
        #region Constructor
        public GastoConfiguracion()
        {
            #region Tabla
            this.ToTable("Gasto");
            #endregion
            #region Keys
            this.HasKey(k => k.Id);
            #endregion
            #region Properties
            this.Property(p => p.Importe).IsRequired();

            this.Property(p => p.Descripcion)
                .IsRequired()
                .HasMaxLength(100);
            #endregion
            #region FOREIGN KEYS
            this.HasOptional<TipoGasto>(x => x.TipoGasto)
                .WithMany(x => x.Gastos)
                .HasForeignKey(x => x.TipoGastoId);

            #endregion
        }
        #endregion

    }
}
