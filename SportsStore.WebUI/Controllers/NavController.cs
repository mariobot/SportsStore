using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private EFProductRepository repository;

        public NavController(EFProductRepository repo) {
            repository = repo;
        }

        public PartialViewResult Menu(string category)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Products
                .Select(x => x.Category)
                .Distinct().OrderBy(x => x);

            return PartialView(categories);
        }
    }
}