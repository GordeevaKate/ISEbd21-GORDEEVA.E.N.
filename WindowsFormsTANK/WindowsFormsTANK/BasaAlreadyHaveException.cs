using System;

    class BasaAlreadyHaveException : Exception
    {
        public BasaAlreadyHaveException() : base("На парковке уже есть такой tank")
        { }
    }

