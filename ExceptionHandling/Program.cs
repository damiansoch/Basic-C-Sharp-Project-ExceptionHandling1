using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your age, please.");
            int age = 0;
            DateTime date = DateTime.Now;
            int year = date.Year;




            try
            {
                age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException();

                }
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Age can't be negative or 0");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Your input was not correct, please provide the correct input");
                return;
            }

            Console.WriteLine($"You were born in {year - age}");
            Console.ReadLine();
        }
    }
}
