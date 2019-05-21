using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace x
{
    class DateComparer : IComparer<Note>
    {
        public int Compare(Note x, Note y)
        {
            return x.CreatedDate.CompareTo(y.CreatedDate);
        }
    }
}