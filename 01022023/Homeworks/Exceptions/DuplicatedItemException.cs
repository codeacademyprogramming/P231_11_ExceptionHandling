using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks.Exceptions
{
    internal class DuplicatedItemException:Exception
    {
        public DuplicatedItemException():base("Eyni element elave edile bilmez!")
        {
        }
    }
}
