using DesignWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignWeb.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories); 
        }
    }
}