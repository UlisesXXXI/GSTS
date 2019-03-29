using AutoMapper;
using GSTS.BaseDeDatos;
using GSTS.models.Gastos;
using GSTS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GSTS.Controllers
{

    

    public class TipoGastoController : Controller
    {
        private GSTScontext _ctx;
        public TipoGastoController()
        {
            _ctx = new GSTScontext();
        }

        // GET: TipoGasto
        public ActionResult Index()
        {
            var list =_ctx.TipoGasto.ToList();
            List<TipoGastoViewModel> lvm = Mapper.Map<List<TipoGastoViewModel>>(list);
            
            return View(lvm);
        }

        // GET: TipoGasto/Details/5
        public async Task<ActionResult> Details(int id)
        {
            TipoGasto entidad = await _ctx.TipoGasto.FindAsync(id);
            if(entidad == null)
            {
                return View("Error");
            }
            TipoGastoViewModel vm = Mapper.Map<TipoGastoViewModel>(entidad);
            return View("Create",vm);
        }

        // GET: TipoGasto/Create
        public ActionResult Create(TipoGastoViewModel vm = null)
        {
            if(vm==null)
            {
                vm = new TipoGastoViewModel();
            }
            
            return View(vm);
        }

        // POST: TipoGasto/Create
        [HttpPost]
        public ActionResult Insert(TipoGastoViewModel vm)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View("Create", vm);
                }

                TipoGasto entidad = Mapper.Map <TipoGasto>(vm);
                _ctx.Entry(entidad).State = System.Data.Entity.EntityState.Added;
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Update(TipoGastoViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", vm);
                }

                TipoGasto entidad = Mapper.Map<TipoGasto>(vm);
                _ctx.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Create",vm);
            }
        }


        // GET: TipoGasto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoGasto/Edit/5
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

        // GET: TipoGasto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoGasto/Delete/5
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
    }
}
