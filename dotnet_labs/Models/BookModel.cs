using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_labs.Models
{
    public class BookModel
    {
        public int Bid { get; set; }
        public string Bname { get; set; }
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; }

        public int GenreID { get; set; }
        public GenreModel Genre { get; set; }
    }
}
