﻿namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
           

            string[] students2 = new[] { "Engin", "Derin", "Salih" };
            students2[3] = "Ahmet";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

              
               
        }
    }
}