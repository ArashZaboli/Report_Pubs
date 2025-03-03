using Report_Pubs.Models;

namespace Report_Pubs.Interface
{
    public interface IAnalysisRepository
    {
        IEnumerable<AnalysisByPublisher> GetAllAnalysis();
    }
}
