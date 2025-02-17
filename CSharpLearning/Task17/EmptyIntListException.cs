using System;

namespace CSharpLearning.Task17
{
    internal class EmptyIntListException : Exception
    {
        public EmptyIntListException() { }

        public EmptyIntListException(string message) : base(message) { }

        public EmptyIntListException(string message, Exception inner) : base(message, inner) { }
    }
}
