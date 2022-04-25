using System;

namespace _19_04_22_OOP_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                for(int i = 0; i < 10;)
                {
                    Console.Clear();
                    string time = DateTime.Now.ToString("h:mm:ss tt");
                    Console.WriteLine(time);
                    System.Threading.Thread.Sleep(1000);
                   
                }
                
            }
        }
    }
}
