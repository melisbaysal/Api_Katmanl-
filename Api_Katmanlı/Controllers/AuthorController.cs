using AutoMapper;
using BLL.AbstractServices;
using BLL.ConcreteServices;
using BLL.DTO_S;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Api_Katmanlı.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpPost]

        public async Task<IActionResult> AddAuthor(AuthorCreateDTO authorCreateDTO)
        {
            await _authorService.CreateAuthor(authorCreateDTO);

            return Ok(authorCreateDTO);

        }

        [HttpGet]

        public async Task<IActionResult> GetAllAuthors()
        {
            return Ok(await _authorService.GetAllAuthors());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(int id, AuthorUpdateDTO authorUpdateDTO)
        {

          await _authorService.UpdateAuthor(authorUpdateDTO, id);
            return NoContent();
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetAuthorsById(int id)
        {
           
            return Ok(await _authorService.GetAuthor(id));
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteAuthor(int id)
        {
           await _authorService.DeleteAuthor(id);
            return NoContent();

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetAuthorWithBook(int id)
        {
           var author =  await _authorService.GetAuthorWithBooks(id);
            return Ok(author);
        }

        
    }
}
