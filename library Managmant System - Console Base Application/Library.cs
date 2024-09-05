using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace library_Managmant_System___Console_Base_Application
{
    public class Library
    {
        //  Static List
        public static List<Author> Authorlist = new List<Author>();
        public static List<Book> BookList = new List<Book>();
        public static List<Member> MemberList = new List<Member>();



        // Seed Book
        public void SeedBook()
        {
            BookList.Add(new Book
            {
                Id = new Guid(),
                IBAN = "4645465",
                Name = "book",
                BookCategory = Enum.BookCategory.Comedy,
                PublishDate = new DateTime(1997, 6, 26),
                AuthorDetails =  new Author(2,"Sehe"),
            });
            BookList.Add(new Book());

        }

        // Seed Member
        public void SeedMember()
        {
            MemberList.Add(new Member(1, "moumin"));
            MemberList.Add(new Member(2, "Talha"));
        }

        // Seed Author
        public void SeedAuthor()
        {
           Authorlist.Add(new Author(1, "moumin"));
           Authorlist.Add(new Author(2, "Talha"));
        }


        //// Display Book List
        //public void DisplayBook()
        //{
        //    Console.WriteLine("List of Books:");
        //    foreach (var bookItem in BookList)
        //    {
        //        Console.WriteLine($"Name: {bookItem.Name}, IBAN: {bookItem.IBAN}, Publish Date: {bookItem.PublishDate}, Author: {bookItem.AuthorDetails.Name}, Category: {bookItem.BookCategory}");
        //    }
        //}


    }



}
