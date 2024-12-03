using Aleksa_Subasic_98_20_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleksa_Subasic_98_20_BookStore.ViewModels
{
    class BooksViewModel
    {
        public ObservableCollection<Book> Books { get; set; }
        public BooksViewModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Description = "Description of a book named, The Great Gatsby",
                    ImagePath = "Images/the_great_gatsby.png",
                    Price = 12.49m
                },
                new Book {
                    Title = "Normal People",
                    Author = "Colleen Hoover",
                    Description = "Description of a book named, Normal People",
                    ImagePath = "Images/normal_people.jpg",
                    Price =  8.99m
                },
                new Book {
                    Title = "The Song of Achillies",
                    Author = "Colleen Hoover",
                    Description = "Description of a book named, The Song of Achillies",
                    ImagePath = "Images/the_song_of_achillies.jpg",
                    Price = 14.99m
                }
            };
        }
    }
}
