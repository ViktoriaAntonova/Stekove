using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opashki_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chislo mejdu 10 i 100");
            int N;
            N = int.Parse(Console.ReadLine());
            if (N < 10 || N > 100)
            {
                Console.WriteLine("error");
                return;
            }
            Queue<int> queue = new Queue<int>();

            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                int number = rand.Next(1, 102); 
                queue.Enqueue(number);
            }
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
                else
                {
                    oddNumbers.Add(num);
                }
            }
            foreach (int even in evenNumbers)
            {
                Console.Write(even + " ");
            }
            for (int i = oddNumbers.Count - 1; i >= 0; i--)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
