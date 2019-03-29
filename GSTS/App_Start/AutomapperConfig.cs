using AutoMapper;
using GSTS.App_Start.CustomResolvers;
using GSTS.models.Gastos;
using GSTS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTS.App_Start
{
    public class AutomapperConfig
    {
        public static void Register()
        {
            
            Mapper.Initialize(cfg => {
                cfg.CreateMap<TipoGasto, SelectListItem>().ConvertUsing(new TipoGastoToSelectedListItem());
                cfg.CreateMap<Gasto, GastosViewModel>();
                cfg.CreateMap<TipoGasto, TipoGastoViewModel>();
                cfg.CreateMap< TipoGastoViewModel, TipoGasto>();
                
                
            });
        }
    }
}