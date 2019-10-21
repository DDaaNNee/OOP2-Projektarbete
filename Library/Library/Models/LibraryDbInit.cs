using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            Book monteCristo = new Book()
            {
                Title = "The Count of Monte Cristo"
            };

            Book yoyomaKoko = new Book()
            {
                Title = "Yoyoma koko"
            };

            Author jkRowling = new Author()
            {
                Name = "J.K Rowling"
            };

            Author stephenKing = new Author()
            {
                Name = "Stephen King"
            };

            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);
            context.Books.Add(yoyomaKoko);

            context.Author.Add(jkRowling);
            context.Author.Add(stephenKing);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
