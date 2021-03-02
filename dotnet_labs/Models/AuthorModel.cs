using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_labs.Models
{
    public class AuthorModel
    {
        public int AID { get; set; }
        public string AName { get; set; }
        public List<BookModel> Books { get; set; }
    }
}
