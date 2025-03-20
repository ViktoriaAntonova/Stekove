using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стекове_2зад
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete chislo mejdu 5 i 55 ");
            int N = int.Parse(Console.ReadLine());
            if (N < 5 || N > 55)
            {
                Console.WriteLine("nevalidno chislo.");
                return;
            }
            Stack<int> f= new Stack<int>();
            f.Push(1); 
            f.Push(1);  
            for (int i = 3; i <= N; i++)
            {
                int num1 = f.Pop();  
                int num2 = f.Peek(); 
                int nextNum = num1 + num2;        
                f.Push(num1);      
                f.Push(nextNum);     
            }
            Console.WriteLine();
            List<int> fibonacciNumbers = new List<int>(f);
            fibonacciNumbers.Reverse();
            Console.WriteLine(string.Join(", ", fibonacciNumbers));
        }
    }
}
