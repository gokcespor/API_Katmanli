using BLL.DTOs.BookDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
	public interface IBookService
	{
		Task CreateBook(BookCreateDTO bookCreateDTO);
		Task DeleteBook(int id);
		Task<BookDTO> GetBook(int id);
		Task UpdateBook(BookUpdateDTO bookUpdateDTO, int id);
		Task<IEnumerable<BookListDTO>> GetAllBooks();
		Task<BookWithAuthorDTO> GetBookWithAuthor(int id);
	}
}
