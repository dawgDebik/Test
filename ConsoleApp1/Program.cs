using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите количество прямоугольников:");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение:");
                int a = int.Parse(Console.ReadLine());
                int d = 0;
                int summ = 0;
                int[] dlina = new int[k];
                int[] shirina = new int[k];

                Console.WriteLine("Введите значения длин:");
                for (int i = 0; i < k; i++)
                {

                    dlina[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Введите значение ширины:");
                for (int j = 0; j < k; j++)
                {
                    shirina[j] = int.Parse(Console.ReadLine());

                }


                for (int i = 0; i < k; i++)
                {

                    d = dlina[i] * shirina[i];
                    if (d < a)
                    {
                        summ++;
                    }

                }
                Console.WriteLine($"количество прямоугольников соотв. условию : {summ}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели ложное значение");

            }
        }
    }
}
