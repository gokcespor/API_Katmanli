using AutoMapper;
using BLL.DTOs.AuthorDTOs;
using BLL.DTOs.BookDTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MappingsProfile
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			#region AuthorMappings
			CreateMap<Author, AuthorCreateDTO>().ReverseMap();
			CreateMap<Author, AuthorDTO>().ReverseMap();
			CreateMap<Author, AuthorListDTO>().ReverseMap();
			CreateMap<Author, AuthorUpdateDTO>().ReverseMap();
			CreateMap<Author, AuthorWithBooksDTO>().ReverseMap();
			#endregion

			#region BookMappings
			CreateMap<Book, BookListDTO>().ReverseMap();
			CreateMap<Book, BookCreateDTO>().ReverseMap();
			CreateMap<Book, BookUpdateDTO>().ReverseMap();
			CreateMap<Book, BookDTO>().ReverseMap();
			CreateMap<Book, BookWithAuthorDTO>().ReverseMap();
			#endregion
		}
	}
}
