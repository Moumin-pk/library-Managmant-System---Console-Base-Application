using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
                AuthorDetails = new Author(2, "Sehe"),
            });
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


        // Add Author

        public void AddAuthor(Author author)
        {
            Authorlist.Add(author);
        }

        // Add Member

        public void AddMember(Member member)
        {
            MemberList.Add(member);
        }

        // Add Book
        public void AddBook(Book book)
        {
            BookList.Add(book);
        }


        // Remove Member
        public void RemoveMember(Member member)
        {
            MemberList.Remove(member);
        }

        // Remove Author

        public void RemoveAuthor(Author author)
        {
            Authorlist.Remove(author);
        }

        // Remove Book

        public void RemoveBook(Book book)
        {
            BookList.Remove(book);
        }

        // Search Author

        public Author SearchAuthor(string AuthorName)
        {
            foreach (Author author in Authorlist)
            {
                if (author.Name == AuthorName)
                {
                    return author;
                }
            }

            return null;

        }

        // Search Book

        public Book SearchBook(string query) 
        {
            {
                foreach (Book book in BookList) {
                    if (book.Name == query || book.IBAN == query)
                    {
                        return book;
                    }
                }
                return null;
            }
        }

            // Search member

            public Member SearchMember(string memberName)
            {
                foreach ( Member member in MemberList) 
                {
                    if (member.Name == memberName)
                    {
                    return member;
                    }
                }

                return null;

            }

    } 
}

