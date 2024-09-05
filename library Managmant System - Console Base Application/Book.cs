using library_Managmant_System___Console_Base_Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace library_Managmant_System___Console_Base_Application
{
    public class Book
    {
        // properties

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? IBAN { get; set; } 
        public DateTime? PublishDate { get; set; }
        public Author AuthorDetails { get; set; }

        public BookCategory BookCategory { get; set; }


        //  Constructor
        public Book()
        {
            Id = Guid.NewGuid();
        }

    }

    

}
