namespace Report_Pubs.Interface
{
    public interface IUnitOfWork : IDisposable
    {

        IAnalysisRepository Analysis { get; }
        IAuthorsBooksRepository AuthorsBooks { get; }
        IBookTypeRepository BookTypes { get; }


        void Save();
    }
}
