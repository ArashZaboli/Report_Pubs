using Report_Pubs.Models;

namespace Report_Pubs.Interface
{
    public interface IBookTypeRepository
    {
        List<string> GetAllTypes();
        List<BookType> GetAllBooksByTypes(List<string> bookTypes);
    }
}
