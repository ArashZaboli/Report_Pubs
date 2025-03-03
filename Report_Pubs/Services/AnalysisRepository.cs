using Report_Pubs.Interface;
using Report_Pubs.Models;

namespace Report_Pubs.Services
{
    public class AnalysisRepository : IAnalysisRepository
    {
        private readonly PubsContext _context;

        public AnalysisRepository(PubsContext context)
        {
            _context = context;
        }

        public IEnumerable<AnalysisByPublisher> GetAllAnalysis()
        {
           return _context.AnalysisByPublishers.ToList();
        }
    }
}
