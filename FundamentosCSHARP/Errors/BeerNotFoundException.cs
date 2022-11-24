using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Errors
{
    public class BeerNotFoundException : Exception
    {
        public BeerNotFoundException() : base() { }
        public BeerNotFoundException(string message) : base(message) { }
        public BeerNotFoundException(string message, Exception inner) : base(message, inner) { }

    }
}
