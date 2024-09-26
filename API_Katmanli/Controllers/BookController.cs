using AutoMapper;
using BLL.AbstractServices;
using BLL.ConcreteServices;
using BLL.DTOs.BookDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Katmanli.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IBookService _bookService;

		public BookController(IMapper mapper, IBookService bookService)
        {
			_mapper = mapper;
			_bookService = bookService;
		}
		[HttpPost]
		public async Task<IActionResult> AddBook(BookCreateDTO bookCreateDTO)
		{
			await _bookService.CreateBook(bookCreateDTO);
			return Ok(bookCreateDTO);
		}
		[HttpGet]
		public async Task<IActionResult> GetAllBooks()
		{
			return Ok(await _bookService.GetAllBooks());
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateBook(BookUpdateDTO bookUpdateDTO, int id)
		{
			await _bookService.UpdateBook(bookUpdateDTO, id);
			return NoContent();
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetBookById(int id)
		{
			return Ok(await _bookService.GetBook(id));
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBook(int id)
		{
			await _bookService.DeleteBook(id);
			return NoContent();
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetBookWithAuthor(int id)
		{
			var book = await _bookService.GetBookWithAuthor(id);
			return Ok(book);
		}
	}
}
