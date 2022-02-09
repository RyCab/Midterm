using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Midterm;
namespace BookStoreTests
{
    public class BookStoreTests
    {
        [Fact]
        public void testTitle()
        {
            var book = BookStoreFunctions.GetBookeByTitle("The Travels of Marco Polo");
            //Assert.True(book.BookTitle == "The Travels of Marco Polo");
        }
        [Fact]
        public void GetAllBooksTest()
        {
            var result = BookStoreFunctions.GetAllBooks();
            //Assert.True(result.Count == 49);
        }
        [Fact]
        public void GetBookByLastNameTest()
        {
            var result = BookStoreFunctions.GetAllBooksByLastName("Polo");

        }

    }
}
