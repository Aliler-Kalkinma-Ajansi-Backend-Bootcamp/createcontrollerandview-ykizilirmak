﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebBackend.Controllers
{
    public class gelismisController : Controller
    {
        // GET: gelismiş
        public ActionResult Index()
        {
            return View();
        }

        // GET: gelismiş/Details/6
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: gelismiş/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gelismiş/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: gelismiş/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: gelismiş/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: gelismiş/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: gelismiş/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}