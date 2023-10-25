namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        private static void ForLoop()
        {

            
            for (int i = 100; i >=0; i=i-2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            
        }
    }
         
}