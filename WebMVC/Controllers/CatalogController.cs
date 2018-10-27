using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Services;
using WebMvc.ViewModels;

namespace WebMvc.Controllers
{

    // controller is the one take the request
    public class CatalogController : Controller
    {
        private ICatalogService _catalogSvc;

        public CatalogController(ICatalogService catalogSvc) =>
            _catalogSvc = catalogSvc;

        public async Task<IActionResult> Index(
            int? CatagoriesFilterApplied, 
            int? SubCatagoriesFilterApplied, int? page)
        {

            int eventsPage = 5;
            var catalog = await 
                _catalogSvc.GetEvents

                //?? null 
                (page ?? 0, eventsPage, CatagoriesFilterApplied, 
                SubCatagoriesFilterApplied);
            var vm = new CatalogIndexViewModel()
            {
                CatalogEvents = catalog.Data,
                CatalogNames = await _catalogSvc.GetCatagories(),
                Types = await _catalogSvc.GetSubCatagories(),

                // by defualt 0 nothing is selected
                CatagoriesFilterApplied = CatagoriesFilterApplied ?? 0,
                SubCatagoriesFilterApplied = SubCatagoriesFilterApplied ?? 0,
                PaginationInfo = new PaginationInfo()
                {
                    //what is the page is look like
                    ActualPage = page ?? 0,
                    ItemsPerPage = eventsPage, //catalog.Data.Count,
                    TotalItems = catalog.Count,
                    TotalPages = (int)Math.Ceiling(((decimal)catalog.Count / eventsPage))
                }
            };

            vm.PaginationInfo.Next = (vm.PaginationInfo.ActualPage == vm.PaginationInfo.TotalPages - 1) ? "is-disabled" : "";
            vm.PaginationInfo.Previous = (vm.PaginationInfo.ActualPage == 0) ? "is-disabled" : "";

            return View(vm);
        }

        [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            return View();
        }

    }
}