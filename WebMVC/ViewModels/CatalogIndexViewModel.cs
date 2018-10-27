using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.ViewModels
{
    public class CatalogIndexViewModel
    {
        //2 dropdown // catalogItems
        public IEnumerable<Event> CatalogEvents { get; set; }
        public IEnumerable<SelectListItem> CatalogNames { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }

        // i nedd to preserve it for the next time
        // if the user selected for the second time preserved
        public int? CatagoriesFilterApplied { get; set; }
        public int? SubCatagoriesFilterApplied { get; set; }
        // which page
        public PaginationInfo PaginationInfo { get; set; }
    }
}
