using BLL.DTO_S.BookDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO_S
{
    public class AuthorWithBooksDTO
    {
        public string Name { get; set; }
        public List<BookListDTO> Books { get; set; }

    }
}
