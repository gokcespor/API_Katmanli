using BLL.DTOs.AuthorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IAuthorService
	{
		Task CreateAuthor(AuthorCreateDTO authorCreateDTO);
		Task DeleteAuthor(int id);
		Task<AuthorDTO> GetAuthor(int id);
		Task UpdateAuthor(AuthorUpdateDTO authorUpdateDTO, int id);
		Task<IEnumerable<AuthorListDTO>> GetAllAuthors();
		Task<AuthorWithBooksDTO> GetAuthorWithBooks(int id);
	}
}
