using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add("Привет");
            list.Add(true);
            list.Add(3.14);
            list.Add(-4);
            list.Add(-4.14);
            Output(list);
            Console.WriteLine($"Количество элементов в списке: {list.Count}");
            list.Insert(2, "второй элемент");
            Output(list);
            list.Reverse();
            Output(list);
            string[] omas = { "первый элемент", "второй элемент", "третий элемент" };
            list.AddRange(omas);
            Output(list);


            Console.ReadKey();
        }
        static void Output(ArrayList list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
    }
}
