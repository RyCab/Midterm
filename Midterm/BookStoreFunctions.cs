using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm.Models;

namespace Midterm
{
    public class BookStoreFunctions
    {
        public double AddNumbers()
        {
            return 1;
        }
        public Book GetBookeByTitle(string title)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books.Find(title);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Book GetBookeById(int id)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books.Find(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Book> GetAllBooks()
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    var a = context.Books.ToList();
                    return context.Books.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Book> GetAllBooksByLastName(string last)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {

                    return context.Books
                        .Join(context.Authors,
                        b => b.BookId,
                        a => a.AuthorId,
                        (b, a) => new
                        {
                            BookId = b.BookId,
                            BookTitle = b.BookTitle,
                            GenreId = b.GenreId,
                            AuthorId = b.AuthorId,
                            YearOfRelease = b.YearOfRelease,
                            firstName = a.AuthorFirst,
                            lastName = a.AuthorLast

                        }).Where(w => w.lastName == last)
                        .Select(b => new Book
                        {
                            BookId = b.BookId,
                            BookTitle = b.BookTitle,
                            GenreId = b.GenreId,
                            AuthorId = b.AuthorId,
                            YearOfRelease = b.YearOfRelease,
                        }).ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
