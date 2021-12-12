using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySim
{
    interface BookInterface
    {
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int ID { get; }
        public int PageCount { get; }
        public uint Amount { get; }


    }
}
