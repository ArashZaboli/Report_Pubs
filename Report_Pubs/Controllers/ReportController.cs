﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Report_Pubs.Interface;
using Report_Pubs.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Report_Pubs.Controllers
{
    public class ReportController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult BarChart()
        {
            IEnumerable<AnalysisByPublisher> analyses = _unitOfWork.Analysis.GetAllAnalysis();
            return View(analyses);
        }

        public IActionResult DropDownList()
        {
            List<AuthorsBook> all = _unitOfWork.AuthorsBooks.GetAllAuthorsBooks();
            ViewBag.Authors = new SelectList(
                all.Where(b => b.FullName != null).GroupBy(b => b.FullName).Select(g => new
            {
            Id = g.First().Id, 
            Name = g.Key}).ToList(), "Id", "Name"); ;


            return View(all);
        }

        [HttpPost]
        public IActionResult GetBooksByAuthor(long authorId)
        {
            List<AuthorsBook> all = _unitOfWork.AuthorsBooks.GetAllAuthorsBooks();
            var books = all
                                 .Where(b => b.Id == authorId)
                                 .ToList(); // جستجو کتاب‌ها براساس نویسنده
            return PartialView("_BooksTable", books);  // ارسال داده‌ها به partial view
        }
    }
}
