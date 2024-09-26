using BLL.DTOs.AuthorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.BookDTOs
{
	public class BookWithAuthorDTO : BaseDTO
	{
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
    }
}
