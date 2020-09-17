using System;

namespace GarageApplication
{
    internal class UI
    {
        public void Print(string messsge)
        {
            Console.WriteLine(messsge);
        }
        public int GetIntInput(string prompt)
        {
            bool success = false;
            int result;
            do
            {
                string answer = GetStringInput(prompt);
                success = int.TryParse(answer, out result);
                if (!success)
                {
                    Console.WriteLine("An integer please!");
                }
                


            } while (!success);
            return result;
        }

        private string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string result = Console.ReadLine();
            return result;
        }

        internal void Clear()
        {
            Console.Clear();
        }
    }
}