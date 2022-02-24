using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7.Models;
using Mission7.Models.ViewModels;

namespace Mission7.Controllers
{
    public class HomeController : Controller
    {
        private IAmazonBookRepository repo;

        public HomeController(IAmazonBookRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == category || category == null)
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    //TotalNumProjects = repo.Books.Count(),
                    TotalNumProjects = (category == null ? repo.Books.Count() : repo.Books.Where(x => x.Category == category).Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

    }
}
