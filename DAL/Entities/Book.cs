using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Book : BaseEntity
	{
        public string Title { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
