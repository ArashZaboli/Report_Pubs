namespace Report_Pubs.Interface
{
    public interface IUnitOfWork : IDisposable
    {

        IAnalysisRepository Analysis { get; }

        void Save();
    }
}
