using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_2
{
    public class MyMatrix
    {
        int length;
        int height;
        int sum = 0;
        int[,] ara;
        List<int> list = new List<int>();
        int n = 0;

        public virtual void InputMatrix()
        {
            Console.Write("Введите длину матрицы: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту матрицы: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("\nЗаполнение матрицы\n");
            ara = new int[length, height];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("Введите число: ");
                    ara[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public virtual void DisplayMatrix()
        {
            Console.WriteLine("Матрица");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("{0} ", ara[i, j]);
                    sum += ara[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСумма матрицы = {0}", sum);
            if (length == height)
            {
                Console.WriteLine("Нижняя треугольная матрица:");
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < height; j++)
                    {
                        if (i >= j)
                            Console.Write(ara[i, j] + "\t");
                        else
                            Console.Write(" \t");
                    }
                }
                Console.WriteLine("\nСумма матрицы = {0}", sum);

                Console.WriteLine("Нижняя треугольная матрица:");
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < height; j++)
                    {
                        if (i <= j)
                            Console.Write(ara[i, j] + "\t");
                        else
                            Console.Write(" \t");
                    }
                }
                Console.WriteLine("\nСумма матрицы = {0}", sum);
            }
            
            Console.ReadKey();
        }
    }
}
