using AutoMapper;
using BLL.DTO_S;
using BLL.DTO_S.AuthorDTOs;
using BLL.DTO_S.BookDTO_s;
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

            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Author, AuthorListDTO>().ReverseMap();
            CreateMap<Author, AuthorCreateDTO>().ReverseMap();
            CreateMap<Author, AuthorUpdateDTO>().ReverseMap();
            CreateMap<Author, AuthorWithBooksDTO>().ReverseMap();

            #endregion

            #region BookMappings

            CreateMap<Book,BookListDTO>().ReverseMap();

            #endregion
        }
    }
}
