using BLL.DTOs.AuthorDTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.BookDTOs
{
    public class BookListDTO : BaseDTO
    {
        public string Title { get; set; }
		public int AuthorId { get; set; }
	}
}
