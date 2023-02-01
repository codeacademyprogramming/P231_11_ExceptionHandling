using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks.Exceptions
{
    internal class OutOfLimitException : Exception
    {
        public OutOfLimitException(string err):base(err)
        {

        }
    }
}
