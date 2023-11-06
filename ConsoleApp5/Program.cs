using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5
{
    
    class Program
    {
       
       static void Main(string[] args)
        {
            ///<summary>выведет и получит число</summary>
            void Vvod(ref int x) 
            {
                Write($"введите {x} число = ");
                x = int.Parse(ReadLine());

            }
           /*
            ///<summary>вспомогательный метод, найдет минимальное число и вернет его</summary>
            int FindMin(int x, int y)
            {
                return (x > y) ? y : x;
            }
            int z = 1, v = 2, c = 3;
            Vvod(ref z);
            Vvod(ref v);
            Vvod(ref c);
            int min = FindMin(z, FindMin(v, c));
            WriteLine($"самое маленькое число - {min}");
            */
            //
            /*
            int Replace(ref int x, ref int y)
            {

                int temp = y;
                y = x;
                x = temp;

                return x;
                
            }
            int a = 1; int b = 2; int c = 3; int d = 4;
            Vvod(ref a);
            Vvod(ref b);
            Vvod(ref c);
            Vvod(ref d);
            int rep1 = Replace(ref a, ref b);
            int rep2 = Replace(ref c, ref d);
            WriteLine($"1 число = {a}, 2 число = {b}, 3 число = {c}, 4 число = {d} "); 

            */

            void FillArray(int[] arr)
            { 
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(333);
                }
            }
            void PrintArray(int[] arr)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    WriteLine(arr[i]);
                }
            }
            int[] array = new int[10];
            FillArray(array);
            PrintArray(array);
            ReadKey();
            
        }
    }
}
