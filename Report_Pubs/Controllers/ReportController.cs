using Microsoft.AspNetCore.Mvc;
using Report_Pubs.Interface;
using Report_Pubs.Models;

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
    }
}
