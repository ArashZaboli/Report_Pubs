using Report_Pubs.Interface;
using Report_Pubs.Models;

namespace Report_Pubs.Services
{
    public class BookTypeRepository : IBookTypeRepository
    {
        private readonly PubsContext _context;

        public BookTypeRepository(PubsContext context)
        {
            _context = context;
        }

        public List<BookType> GetAllBooksByTypes(List<string> bookTypes)
        {
            return _context.BookTypes.Where(b => bookTypes.Contains(b.BookType1)).ToList();
        }

        public List<string> GetAllTypes()
        {
            return _context.BookTypes.Select(p => p.BookType1).Distinct().ToList();
        }
    }
}
