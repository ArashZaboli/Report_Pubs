using Report_Pubs.Models;

namespace Report_Pubs.Interface
{
    public interface IAuthorsBooksRepository
    {
        List<AuthorsBook> GetAllAuthorsBooks();
        List<AuthorsBook> GetBooksByAuthorID(long authorId);
    }
}
