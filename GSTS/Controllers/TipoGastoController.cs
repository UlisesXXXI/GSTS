﻿using AutoMapper;
using GSTS.BaseDeDatos;
using GSTS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoGasto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoGasto/Create
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
