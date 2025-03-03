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
    }
}
