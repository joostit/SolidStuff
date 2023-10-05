using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Box<TContents> 
        where TContents: notnull, IComparable
    {

        public TContents Contents { get; set; } = default(TContents)!;

        public TContents Replace(TContents newItem)
        {
            TContents old = Contents;
            Contents = newItem;
            return old;
        }

        public bool IsLargerThanZero()
        {
            return Contents.CompareTo(0) > 0;
        }

    }
}
