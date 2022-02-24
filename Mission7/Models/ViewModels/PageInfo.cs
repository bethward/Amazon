using System;
namespace Mission7.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumProjects { get; set; }

        public int ProjectsPerPage { get; set; }

        public int CurrentPage { get; set; }

        //figure out how many pages are needed

        public int TotalPages => (int) Math.Ceiling((double)TotalNumProjects / ProjectsPerPage);
    }
}
