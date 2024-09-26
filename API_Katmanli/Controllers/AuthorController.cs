using AutoMapper;
using BLL.AbstractServices;
using BLL.ConcreteServices;
using BLL.DTOs.AuthorDTOs;
using DAL.Data;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Katmanli.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class AuthorController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IAuthorService _authorService;

		public AuthorController(IMapper mapper, IAuthorService authorService)
        {
			_mapper = mapper;
			_authorService = authorService;
		}
		[HttpPost]
        public async Task<IActionResult> AddAuthor(AuthorCreateDTO authorCreateDTO)
		{
			await _authorService.CreateAuthor(authorCreateDTO);
			return Ok(authorCreateDTO);
		}
		[HttpGet]
		public async Task<IActionResult> GetAllAuthors()
		{
			return Ok(await _authorService.GetAllAuthors());
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateAuthor(AuthorUpdateDTO authorUpdateDTO, int id)
		{
			await _authorService.UpdateAuthor(authorUpdateDTO, id);
			return NoContent();
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetAuthorById(int id)
		{
			return Ok(await _authorService.GetAuthor(id));
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAuthor(int id)
		{
			await _authorService.DeleteAuthor(id);
			return NoContent();
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetAuthorWithBooks(int id)
		{
			var author = await _authorService.GetAuthorWithBooks(id);
			return Ok(author);
		}
	}
}
