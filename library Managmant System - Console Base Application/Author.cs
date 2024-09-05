using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_Managmant_System___Console_Base_Application
{
    public class Author
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public Author(int id , string name)
        {
            Id = id;
        ; Name = name;
        }
        
    }
}
