using System;

namespace LearnCsharp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Введите размер массива: ");
            //try
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int[] array = new int[x];
            //    int y = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (y % 5 == 2)
            //        {
            //            array[i] = y;
            //        }
            //        y++;
            //    }
            //    foreach (int i in array)
            //    {
            //        if (i != 0) { Console.WriteLine(i); }
            //    }

            //}
            //catch 
            //{
            //    Console.WriteLine("Введёное значение размера массива не верно");
            //}

            //int x = 11;
            //double[] array = new double[x];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Math.Pow(2, i);
            //}
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //for (int i = x - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}
            Random rnd = new Random();
            int x = 10, index = 0, num = 100;
            int[] array = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 50);
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            for (int i = 0;i < array.Length; i++)
            {
                    if (array[i] < num)
                    {
                        num = array[i];
                        index = i;
                    }
            }
            Console.WriteLine();
            Console.WriteLine(num);
            Console.WriteLine(index);
        }
    }
}
