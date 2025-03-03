using Microsoft.AspNetCore.Mvc.Rendering;
using Report_Pubs.Interface;
using Report_Pubs.Models;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Report_Pubs.Services
{
    public class AuthorsBooksRepository : IAuthorsBooksRepository
    {
        private readonly PubsContext _context;

        public AuthorsBooksRepository(PubsContext context)
        {
            _context = context;
        }

        public List<AuthorsBook> GetAllAuthorsBooks()
        {
            return _context.AuthorsBooks.ToList();
        }

        public List<AuthorsBook> GetBooksByAuthorID(long authorId)
        {
            List<AuthorsBook> all = _context.AuthorsBooks.ToList();
            string name = all.Where(b => b.Id == authorId).Select(p => p.FullName).First();
            var books = all
                                 .Where(b => b.FullName == name)
                                 .ToList();
            return books;
        }
    }
}
