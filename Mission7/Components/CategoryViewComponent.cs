using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;

namespace Mission7.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IAmazonBookRepository repo { get; set; }

        public CategoryViewComponent (IAmazonBookRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["Category"];

            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
