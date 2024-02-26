using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prak13_osnov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Введите количество элементов, которые хотите добавить:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числа:");
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                list.Add(b);
            }

            Console.WriteLine("Введите индекс, с которого хотите добавить новую коллекцию:");
            int n1 = int.Parse(Console.ReadLine());

            ArrayList newCollection = new ArrayList() { 100, 200, 300 };
            list.InsertRange(n1, newCollection);

            int n = n1 / 2;

            Console.WriteLine("Введите количество элементов для удаления:");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                list.RemoveAt(n);
            }

            Console.WriteLine("Новый список:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //{   ArrayList list = new ArrayList();

            //    Console.WriteLine("Введите количество сколько хотите ввести");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Вводите цифры");


            //    for (int i = 0; i < a; i++)
            //    {
            //        int b = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Введите число{i + 1}");
            //        list.Add(b);
            //    }

            //    foreach (object e in list)
            //    {
            //        Console.WriteLine(e);
            //    }

            //    Console.WriteLine("Введите сколько хотите удалить");
            //    int c = int.Parse(Console.ReadLine());  

            //    list.RemoveAt(c);

            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        Console.WriteLine(list[i]);
            //    }

            //    Console.ReadLine();




                   
        }
    }
}
