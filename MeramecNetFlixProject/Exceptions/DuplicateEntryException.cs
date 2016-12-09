using System;

namespace MeramecNetFlixProject.Exceptions
{
    public class DuplicateEntryException : Exception
    {
        public DuplicateEntryException(string message) : base(message)
        {
        }
    }
}