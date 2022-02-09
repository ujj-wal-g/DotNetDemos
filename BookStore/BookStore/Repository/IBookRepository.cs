using BookStore.Model;
using Microsoft.AspNetCore.JsonPatch;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBookAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(BookModel bookModel, int bookId);
        Task UpdateBookByPatchAsync(JsonPatchDocument bookModel, int bookId);
        Task deleteBookAsync(int bookId);

    }
}
