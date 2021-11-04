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
            var resArr1 = new char[arr2.Length];
            var resArr2 = new char[arr3.Length];
            for (var i = 0; i < arr2.Length; i++)
            {
                var resultEven = (char)(arr2[i] + 96);
                resArr1[i] = resultEven;
            }

            for (var i = 0; i < arr3.Length; i++)
            {
                var resultOdd = (char)(arr3[i] + 96);
                resArr2[i] = resultOdd;
            }

            for (var i = 0; i < resArr1.Length; i++)
            {
                if (resArr1[i] == 'a' ||
                    resArr1[i] == 'e' ||
                    resArr1[i] == 'i' ||
                    resArr1[i] == 'd' ||
                    resArr1[i] == 'h' ||
                    resArr1[i] == 'j')
                {
                    resArr1[i] = (char)((int)resArr1[i] - 32);
                }
            }

            for (var i = 0; i < resArr2.Length; i++)
            {
                if (resArr2[i] == 'a' ||
                    resArr2[i] == 'e' ||
                    resArr2[i] == 'i' ||
                    resArr2[i] == 'd' ||
                    resArr2[i] == 'h' ||
                    resArr2[i] == 'j')
                {
                    resArr2[i] = (char)((int)resArr2[i] - 32);
                }
            }

            foreach (var c in resArr1)
            {
                Console.Write(c + " ");
            }

            // Test
            Console.WriteLine();
            foreach (var c in resArr2)
            {
                Console.Write(c + " ");
            }
        }
    }
}