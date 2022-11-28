using System;

namespace OOP__4
{
    class UserException : Exception
    {
        public UserException(string Emessage) : base(Emessage) { }
    }

    class ProductsException : ArgumentException
    {
        public ProductsException(string Emessage) : base(Emessage) { }
    }
    class NecklaceException : NullReferenceException
    {
        public NecklaceException(string Emessage) : base(Emessage) { }
    }
}
