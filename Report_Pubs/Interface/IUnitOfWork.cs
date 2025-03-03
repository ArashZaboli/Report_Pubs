namespace Report_Pubs.Interface
{
    public interface IUnitOfWork : IDisposable
    {

        IAnalysisRepository Analysis { get; }
        IAuthorsBooksRepository AuthorsBooks { get; }

        void Save();
    }
}
