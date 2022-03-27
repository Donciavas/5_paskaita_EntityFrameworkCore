using Microsoft.EntityFrameworkCore;
using Sandbox.Contexts;
using System;
using System.Linq;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new BookContext();
            var book = dbContext.Books.Where(book => book.Id == new Guid("73F6C5E4-4E1B-4155-B8BA-48054E643A4B")).Include(x => x.Pages).First();
            
            //dbContext.Books cia musu visos knygos
            //dbContext.Pages cia musu visi puslapiai
            // naudoti grazinimui .ToList();

            dbContext.Books.Remove(book);

            dbContext.SaveChanges();
        }
    }
}
