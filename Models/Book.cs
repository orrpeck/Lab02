using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }

    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "So Do",Author = "Vu Trong Phung" ,CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Tat Den", Author = "Ngo Tat To", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Nhat Ky Trong Tu", Author = "Ho Chi Minh", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookId = 4, Title = "Ti Quay 1", Author = "Hong Hai", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookId = 5, Title = "Ti Quay 2", Author = "Hong Hai", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookId = 6, Title = "Ti Quay 3", Author = "Hong Hai", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookId = 7, Title = "Ti Quay 4", Author = "Hong Hai", CoverImage = "Assets/7.png" });
            books.Add(new Book { BookId = 8, Title = "Ti Quay 5", Author = "Hong Hai", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookId = 9, Title = "Ti Quay 6", Author = "Hong Hai", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookId = 10, Title = "Ti Quay 7", Author = "Hong Hai", CoverImage = "Assets/10.png" });

            return books;
        }
    }
}
