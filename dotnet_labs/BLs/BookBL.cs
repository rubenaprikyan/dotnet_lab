using dotnet_labs.BLs.Interfaces;
using dotnet_labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_labs.BLs
{
    public class BookBL : IBookBL
    {
        public List<BookModel> GetBooks(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
