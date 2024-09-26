using AutoMapper;
using BLL.AbstractServices;
using BLL.DTOs.AuthorDTOs;
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
	public class AuthorService : IAuthorService
	{
		private readonly IRepository<Author> _authorRepository;
		private readonly IMapper _mapper;
		private readonly IAuthorRepository _repository;

		public AuthorService(IRepository<Author> authorRepository, IMapper mapper, IAuthorRepository repository)
        {
			_authorRepository = authorRepository;
			_mapper = mapper;
			_repository = repository;
		}
        public async Task CreateAuthor(AuthorCreateDTO authorCreateDTO)
		{
			await _authorRepository.AddAsync(_mapper.Map<Author>(authorCreateDTO));
		}

		public async Task DeleteAuthor(int id)
		{
			await _authorRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<AuthorListDTO>> GetAllAuthors()
		{
			var authorList = await _authorRepository.GetAllAsync();
			return _mapper.Map<IEnumerable<AuthorListDTO>>(authorList);
		}

		public async Task<AuthorDTO> GetAuthor(int id)
		{
			var author = await _authorRepository.GetByIdAsync(id);
			return _mapper.Map<AuthorDTO>(author);
		}

		public async Task<AuthorWithBooksDTO> GetAuthorWithBooks(int id)
		{
			var author = await _repository.GetAuthorWithBooks(id);
			return _mapper.Map<AuthorWithBooksDTO>(author);
		}

		public async Task UpdateAuthor(AuthorUpdateDTO authorUpdateDTO, int id)
		{
			var author = await _authorRepository.GetByIdAsync(id);
			author.Name = authorUpdateDTO.Name;
			await _authorRepository.UpdateAsync(author);
		}
	}
}
