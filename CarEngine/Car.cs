using System;

namespace CarEngine
{
    public class Car
    {
        public bool Drive()
        {
            Engine e = new Engine();
            return e.Start();
        }
    }
}