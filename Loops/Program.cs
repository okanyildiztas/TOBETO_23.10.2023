namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 11);
          

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