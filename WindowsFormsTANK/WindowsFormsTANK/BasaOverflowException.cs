using System;
namespace WindowsFormsTANK
{
    public class BasaOverflowException : Exception
    {
        public BasaOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
