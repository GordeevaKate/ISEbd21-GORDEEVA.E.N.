using System;

    public class BasaNotFoundException : Exception
    {
        public BasaNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        { }
    }

