using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }

        public BookModel GetBookById(int id)
        {
            return Datasource().Where(x => x.Id == id).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return Datasource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }

        private List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="Ago", Author="kabiesi"},
                new BookModel(){Id=2, Title="Ag1", Author="kabiesi"},
                new BookModel() { Id = 3, Title = "Ag3", Author = "kabiesi" },
                new BookModel() { Id = 4, Title = "Ag4", Author = "kabiesi" },
        };
        }
       

    }
}
