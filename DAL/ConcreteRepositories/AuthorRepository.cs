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
	public class AuthorRepository : IAuthorRepository
	{
		private readonly AppDbContext _context;

		public AuthorRepository(AppDbContext context)
		{
			_context = context;
		}
		public Task<Author> GetAuthorWithBooks(int id)
		{
			var author = _context.Authors.Include(x => x.Books).FirstOrDefaultAsync(x => x.Id == id);
			return author;
		}
	}
}
