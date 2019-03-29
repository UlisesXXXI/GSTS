using AutoMapper;
using GSTS.models.Gastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTS.App_Start.CustomResolvers
{
    
    public class TipoGastoToSelectedListItem : ITypeConverter<TipoGasto, SelectListItem>
    {
       

        public SelectListItem Convert(TipoGasto source, SelectListItem destination, ResolutionContext context)
        {
            if(destination == null)
            {
                destination = new SelectListItem();
            }
            destination.Value = source.Id.ToString();
            destination.Text = source.Description;
            return destination;
            
        }
    }
}