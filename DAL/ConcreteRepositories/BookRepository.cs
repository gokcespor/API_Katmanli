using DAL.AbstractRepositories;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ConcreteRepositories
{
	public class BookRepository : IBookRepository
	{
		private readonly AppDbContext _context;

		public BookRepository(AppDbContext context)
        {
			_context = context;
		}
        public async Task<Book> GetBookWithAuthor(int id)
		{
			var bookWithAuthor = await _context.Books.Include(x => x.Author).FirstOrDefaultAsync(x => x.Id == id);
			return bookWithAuthor;
		}
	}
}
