﻿using BLL.DTOs.BookDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AuthorDTOs
{
    public class AuthorWithBooksDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<BookListDTO> Books { get; set; }
    }
}
