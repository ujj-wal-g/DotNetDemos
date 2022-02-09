using AutoMapper;
using BookStore.Data;
using BookStore.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class BooksRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BooksRepository(BookStoreContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BookModel>> GetAllBookAsync()
        {
            //var records = await _context.Books.Select(
            //    x => new BookModel()
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //        Description = x.Description,
            //    }).ToListAsync();

           // return records;
           var record = await _context.Books.ToListAsync();
            return _mapper.Map<List<BookModel>>(record);
        }
        public async Task<BookModel> GetBookByIdAsync(int bookId)
        {
            //var records = await _context.Books.Where(x => x.Id == bookId).Select(
            //    x => new BookModel()
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //        Description = x.Description,
            //    }).FirstOrDefaultAsync();
            //return records;
            var book = await _context.Books.FindAsync(bookId);
            return _mapper.Map<BookModel>(book);

        }
        public async Task<int> AddBookAsync(BookModel bookModel)
        {
            var book = new Books()
            {
                Title = bookModel.Title,
                Description = bookModel.Description
            };
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }
        public async Task UpdateBookAsync(BookModel bookModel, int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                book.Title = bookModel.Title;
                book.Description = bookModel.Description;
                _context.SaveChangesAsync();

            }
        }
        public async Task UpdateBookByPatchAsync(JsonPatchDocument bookModel, int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
               bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();

            }
        }
        public async Task deleteBookAsync( int bookId)
        {
            var book = new Books { Id = bookId };
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChangesAsync();

            }
        }

    }
}
