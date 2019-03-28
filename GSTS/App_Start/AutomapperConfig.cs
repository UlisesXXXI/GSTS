using AutoMapper;
using GSTS.models.Gastos;
using GSTS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTS.App_Start
{
    public class AutomapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Gasto, GastosViewModel>()
 .              

                
            });
        }
    }
}