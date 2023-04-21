﻿using ElectronicsShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsShop.Data;

namespace ElectronicsShop.Web.Areas.Store.Controllers
{
    public class HomeController : Controller
    {
        // GET: Store/Home

        public ActionResult Index()
        {
            ViewBag.ShowCategoriesView = false;
            return View("~/Areas/Store/Views/Home/Index.cshtml");
        }

        public ActionResult ProductGrid()
        {
            ViewBag.ShowCategoriesView = true;
            // Load the partial view with products for the specified category
            return PartialView("~/Areas/Store/Views/Shared/_ProductGrid.cshtml");
        }
    }
}