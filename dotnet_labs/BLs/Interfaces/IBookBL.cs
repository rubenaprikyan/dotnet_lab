using dotnet_labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_labs.BLs.Interfaces
{
    public interface IBookBL
    {
        List<BookModel> GetBooks(int authorId);
    }
}
