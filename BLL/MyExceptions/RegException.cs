using System;

namespace BLL.MyExceptions
{
    public class RegException : Exception
    {
        public RegException(string message) : base(message) { }
    }
}