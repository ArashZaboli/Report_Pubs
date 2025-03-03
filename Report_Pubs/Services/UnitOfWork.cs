using Report_Pubs.Interface;
using Report_Pubs.Models;

namespace Report_Pubs.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PubsContext _context;

        public IAnalysisRepository Analysis { get; private set; }

        public UnitOfWork(PubsContext context)
        {
            _context = context;
            Analysis = new AnalysisRepository(_context);
        }

        public void Save()
        {
            _context.Dispose();
        }

        public void Dispose()
        {
            _context.SaveChanges();
        }
    }
}
