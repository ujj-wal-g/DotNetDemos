using BookStore.Data;
using BookStore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BooksRepository: IBookRepository
    {
        private readonly BookStoreContext _context;

        public BooksRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBookAsync()
        {
            var records = await _context.Books.Select(
                x=>new BookModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                }).ToListAsync();
            return records;
        }
        public async Task<BookModel>GetBookByIdAsync(int bookId)
        {
            var records = await _context.Books.Where(x=>x.Id==bookId).Select(
                x => new BookModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                }).FirstOrDefaultAsync();
            return records;
        }
        public async Task<int>AddBookAsync(BookModel book)
        {
            var id = new Books
            {
                Title = book.Title,
                Description= book.Description
            };
            _context.Books.Add(id);
            await _context.SaveChangesAsync();
            return id.Id;
        }
    }
}
