using AutoMapper;
using BLL.AbstractServices;
using BLL.DTOs.AuthorDTOs;
using BLL.DTOs.BookDTOs;
using BLL.DTOs.BookDTOs;
using DAL.AbstractRepositories;
using DAL.ConcreteRepositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
	public class BookService : IBookService
	{
		private readonly IRepository<Book> _bookRepository;
		private readonly IMapper _mapper;
		private readonly IBookRepository _repository;
		private readonly IRepository<Author> _authorRepository;

		public BookService(IRepository<Book> bookRepository, IMapper mapper, IBookRepository repository, IRepository<Author> authorRepository)
		{
			_bookRepository = bookRepository;
			_mapper = mapper;
			_repository = repository;
			_authorRepository = authorRepository;
		}
		public async Task CreateBook(BookCreateDTO bookCreateDTO)
		{
			await _bookRepository.AddAsync(_mapper.Map<Book>(bookCreateDTO));
		}

		public async Task DeleteBook(int id)
		{
			await _bookRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<BookListDTO>> GetAllBooks()
		{
			var bookList = await _bookRepository.GetAllAsync();
			return _mapper.Map<IEnumerable<BookListDTO>>(bookList);
		}

		public async Task<BookDTO> GetBook(int id)
		{
			var book = await _bookRepository.GetByIdAsync(id);
			return _mapper.Map<BookDTO>(book);
		}

		public async Task<BookWithAuthorDTO> GetBookWithAuthor(int id)
		{
			var book = await _repository.GetBookWithAuthor(id);
			return _mapper.Map<BookWithAuthorDTO>(book);
		}

		public async Task UpdateBook(BookUpdateDTO bookUpdateDTO, int id)
		{
			var book = await _bookRepository.GetByIdAsync(id);
			book.Title = bookUpdateDTO.Title;
			await _bookRepository.UpdateAsync(book);
		}
	}
}
