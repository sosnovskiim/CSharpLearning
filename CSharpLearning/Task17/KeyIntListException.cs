using System;

namespace CSharpLearning.Task17
{
    internal class KeyIntListException : Exception
    {
        public KeyIntListException() { }

        public KeyIntListException(string message) : base(message) { }

        public KeyIntListException(string message, Exception inner) : base(message, inner) { }
    }
}
