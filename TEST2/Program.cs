using System;
using System.Security.Cryptography.X509Certificates;
namespace Demo 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int count =Getid();
            int[] id = new int[count];
            string[] title = new string[count];
            string[] description = new string[count];

            Points(id, title, description);
            print(id, title, description);  
           
        }

        public static int Getid() 
        {
            Console.WriteLine("Enter number of tasks");
            int count =int.Parse(Console.ReadLine()!);
            return count;
        }
    
        public static void Points(int[] id, string[] title, string[]description)
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Task : {i +1}");
           
                Console.WriteLine("enter title ");
              
                title[i]= Console.ReadLine()!;
                Console.WriteLine("if task have description or not (y/n)");
              
                string answer = Console.ReadLine()!;
                
                if (answer == "y")
                {
                    Console.WriteLine("enter description");
                    description[i] = Console.ReadLine()!;
                }
                else { };
                
            }
    
        }
        public static void print(int[] id, string[] title, string[] description)
        {
            for (int i = 0; i < id.Length; i++) 
            {
                Console.WriteLine($"Task : {i+1}\ntitle : {title[i]}\ndescription :{description[i]}" );

            }    
        }   
    }


}
