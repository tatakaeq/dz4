using System;
using System.Linq;

namespace Dz4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr1 = new int[n];
            var rnd = new Random();
            var evenCounter = 0;
            var oddCounter = 0;
            for (var i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(1, 26);
            }

            for (var i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    evenCounter++;
                }
                else
                {
                    oddCounter++;
                }
            }

            var arr2 = new int[evenCounter];
            var arr3 = new int[oddCounter];
            arr2 = arr1.Where(x => x % 2 == 0).ToArray();
            arr3 = arr1.Where(x => x % 2 != 0).ToArray();
            for (var i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}