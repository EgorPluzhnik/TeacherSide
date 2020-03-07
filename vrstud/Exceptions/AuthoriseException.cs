using System;

namespace vrstud
{
    public class AuthoriseException : Exception
    {
        public AuthoriseException() : this("")
        {
        }

        public AuthoriseException(string msg)
        {
//            throw new Exception(msg, this);
        }
    }
}