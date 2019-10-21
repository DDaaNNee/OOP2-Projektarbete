using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {

        BookService bookService;

        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);

            ShowAllBooks(bookService.All());
        }
        // La till den här metoden för att kunna skriva ut alla författare
        //private void ShowAllAuthors(IEnumerable<Author> authors)
        //{
        //    lbAuthors.Items.Clear();
        //    foreach (Author author in authors)
        //    {
        //        lbAuthors.Items.Add(author);
        //    }
        //}

        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }

        private void BTNChangeBook_Click(object sender, EventArgs e)
        {
            Book b = lbBooks.SelectedItem as Book;
            if (b != null)
            {   // Switch för att se så att knappen fungerar flera gånger om
                switch (b.Title)
                {
                    case "Yoyoma koko":
                        b.Title = "The Count of Monte Cristo";
                        break;

                    case "The Count of Monte Cristo":
                        b.Title = "Yoyoma koko";
                        break;
                }
                bookService.Edit(b);
            }
            // Ful-fix på att listan inte använder sig av event ÄN, för att uppdatera så att man ser om metoden överhuvudtaget fungerar.
            ShowAllBooks(bookService.All());
        }
        
    }
}
