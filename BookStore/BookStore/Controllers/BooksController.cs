using BookStore.Model;
using BookStore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> GettAllBooks()
        {
            var books = await _bookRepository.GetAllBookAsync();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost("")]
        public async Task<IActionResult> AddNewBook([FromBody]BookModel bookModel)
        {
            var id = await _bookRepository.AddBookAsync(bookModel);
            return Ok("Added Succesfully");
            return CreatedAtAction(nameof(GetBookById), new { id = id, controller = "books" }, id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewBook([FromBody] BookModel bookModel, [FromRoute] int id)
        {
             await _bookRepository.UpdateBookAsync(bookModel,id);
            return Ok(bookModel);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookByPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await _bookRepository.UpdateBookByPatchAsync(bookModel, id);
            return Ok("Partially Updated");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteNewBook([FromRoute] int id)
        {
           await _bookRepository.deleteBookAsync(id);
            return Ok("Deleted");
        }

    }
}
