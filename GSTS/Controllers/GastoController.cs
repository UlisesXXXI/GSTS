using AutoMapper;
using GSTS.BaseDeDatos;
using GSTS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTS.Controllers
{
    public class GastoController : Controller
    {
        private GSTScontext _ctx;
        public GastoController()
        {
            _ctx = new GSTScontext();
        }

        // GET: Gasto
        public ActionResult Index()
        {

            var listado =  _ctx.Gastos.ToList();
            List<GastosViewModel> glv = Mapper.Map<List<GastosViewModel>>(listado);
            
            return View(glv);
        }

        // GET: Gasto/Details/5
        public ActionResult Details(int id)
        {
            var vm = ObtainViewModel(new GastosViewModel() { Id = id });
            return View("Create",vm);
        }

        // GET: Gasto/Create
        public ActionResult Create(GastosViewModel vm = null)
        {
            if(vm == null)
            {
                vm = new GastosViewModel();
            }
            vm = ObtainViewModel(vm);
            return View(vm);
        }

        // POST: Gasto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gasto/Edit/5
        public ActionResult Edit(int id)
        {
            var vm = ObtainViewModel(new GastosViewModel() { Id = id });

            return View("Create",vm);
        }

        // POST: Gasto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gasto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gasto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public GastosViewModel ObtainViewModel(GastosViewModel vm = null)
        {
            if(vm==null)
            {
                vm = new GastosViewModel();
            }else
            {
                if(vm.Id != 0)
                {
                    vm = Mapper.Map<GastosViewModel>(_ctx.Gastos.Find(vm.Id));
                }
            }

            vm.slTipoGastos = Mapper.Map<List<SelectListItem>>(_ctx.TipoGasto.ToList());
            return vm;

        }
    }
}
