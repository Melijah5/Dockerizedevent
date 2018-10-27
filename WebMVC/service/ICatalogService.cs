using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;


namespace WebMvc.Services
{
    //interface is only Definition
    //then we implement on catalogservice
    public interface ICatalogService
    {
        Task<Catalog> GetEvents(int page, int take, int? catalogname, int? type);
        //listing into dropdown
        Task<IEnumerable<SelectListItem>> GetCatagories();
        Task<IEnumerable<SelectListItem>> GetSubCatagories();
    }
}
