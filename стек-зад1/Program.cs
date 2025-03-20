using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стек_зад1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chislo v intervala 10 do 100");
            int N = int.Parse(Console.ReadLine());
            if (N < 10 || N > 100)
            {
                Console.WriteLine("ne e v intervala.");
                return;
            }
            Stack<int> oddNumbers = new Stack<int>();
            List<int> evenNumbers = new List<int>();
            Random rand = new Random();
            Console.WriteLine("Chisla: ");
            for (int i = 0; i < N; i++)
            {
                int num = rand.Next(1, 102); 
                Console.Write(num + " ");

                if (num % 2 == 0)
                    evenNumbers.Add(num);
                else
                    oddNumbers.Push(num);  
            }
            Console.WriteLine();
            Console.Write("Chetni: ");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("Nechetni: ");
            while (oddNumbers.Count > 0)
            {
                Console.Write(oddNumbers.Pop() + " ");
            }
        }
    }
}
