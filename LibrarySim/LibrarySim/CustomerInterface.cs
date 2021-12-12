using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySim
{
    interface CustomerInterface
    {
        public string Name { get; }
        public int Age { get; }
        public int ID { get; }
        public List<Book> Books { get; }
    }
}
