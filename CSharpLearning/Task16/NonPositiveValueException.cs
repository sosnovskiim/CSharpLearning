using System;

namespace CSharpLearning.Task16
{
    internal class NonPositiveValueException : Exception
    {
        public NonPositiveValueException() { }

        public NonPositiveValueException(string message) : base(message) { }

        public NonPositiveValueException(string message, Exception inner) : base(message, inner) { }
    }
}
