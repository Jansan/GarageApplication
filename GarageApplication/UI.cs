using System;

namespace GarageApplication
{
    internal class UI
    {
        public void Print(string messsge)
        {
            Console.WriteLine(messsge);
        }

        internal void Clear()
        {
            Console.Clear();
        }
    }
}