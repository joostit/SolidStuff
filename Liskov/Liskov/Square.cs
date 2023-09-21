using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Square : Rectangle
    {

        public int Sidelength
        {
            get
            {
                return Width;
            }
            set
            {
                Width = value;
                Length = value;
            }

        }


    }
}
