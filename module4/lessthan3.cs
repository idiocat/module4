using System;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace module4
{
    internal class lessthan3
    {
        public static void Massive()
        {

            Console.WriteLine("\nLesson 3");
            Console.WriteLine("Task 7: reversing a name\n");
            NameReverse();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 11: twisting 2x array\n");
            DisplayArray();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 12: sorting 1x array\n");
            SortArray();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 13: sum of 1x array\n");
            SumArray();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 14: super massive\n");
            SuperMassive();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 15: positivity of 1x array\n");
            NoNegative();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 16: positivity of 2x array\n");
            NoNegativex2();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Task 17: sorting 2x array\n");
            SortArrayx2();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

        }

        static void NameReverse() {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            string name_reversed = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                if (i == name.Length - 1) { name_reversed += char.ToUpper(name[i]); }
                else if (i == 0) { name_reversed += char.ToLower(name[i]); }
                else { name_reversed += name[i];  };
            }
            Console.Write($"I'm gonna call you {name_reversed} though.");
        }

        class IntArrayx2
        {
            public int[,] arrgh { get; set; }
            public int first_order { get; set; }
            public int second_order { get; set; }

            public IntArrayx2(int i, int k)
            {
                var rng = new Random();
                var arrgh = new int[i, k];
                for (int j = 0; j < i; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        arrgh[j, l] = rng.Next(sbyte.MinValue, sbyte.MaxValue);
                    }
                }
                this.arrgh = arrgh;
                this.first_order = arrgh.GetUpperBound(0);
                this.second_order = arrgh.GetUpperBound(1);
            }

            public string this[int i, int k] { get { return arrgh[i,k].ToString(); } }

            public void print_like_it_is()
            {
                for (int i = 0; i <= first_order; i++)
                {
                    for (int k = 0; k <= second_order; k++)
                    {
                        Console.Write(arrgh[i, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            public void print_it_twisted()
            {
                for (int i = 0; i <= second_order; i++)
                {
                    for (int k = 0; k <= first_order; k++)
                    {
                        Console.Write(arrgh[k, i] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void sort()
            {
                for (int i = 0; i <= first_order; i++)
                {
                    for (int k = 0; k <= second_order; k++)
                    {
                        for (int j = k + 1; j <= second_order; j++)
                        {
                            if (arrgh[i,k] > arrgh[i,j])
                            {
                                var bigger = arrgh[i,k];
                                arrgh[i,k] = arrgh[i,j];
                                arrgh[i,j] = bigger;
                            }
                        }
                    }
                }
            }

        }

        static void DisplayArray()
        {
            IntArrayx2 some_array = new IntArrayx2(4, 3);
            some_array.print_like_it_is();
            Console.WriteLine();
            some_array.print_it_twisted();
        }

        static void SortArray()
        {
            int[] arrgh = { 5, 6, 9, 1, 2, 3, 4 };
            Console.WriteLine("Initial array: " + string.Join(' ', arrgh));
            for (int i = 0; i < arrgh.Length - 1; i++)
            {
                for (int j = i + 1; j < arrgh.Length; j++)
                {
                    if (arrgh[i] > arrgh[j])
                    {
                        var bigger = arrgh[i];
                        arrgh[i] = arrgh[j];
                        arrgh[j] = bigger;
                    }
                }
            }
            Console.WriteLine("Sorted array: " + string.Join(' ', arrgh));

        }

        static void SumArray()
        {
            int[] arrgh = { 5, 6, 9, 1, 2, 3, 4 };
            Console.WriteLine("Initial array: " + string.Join(' ', arrgh));
            int arrgh_sum = 0;
            foreach (int i in arrgh) { arrgh_sum += i; }
            Console.WriteLine("Sum of the array: " + arrgh_sum);
        }

        static void SuperMassive()
        {
            int[][] arrgh = new int[3][];
            arrgh[0] = new int[2] { 1, 2 };
            arrgh[1] = new int[3] { 1, 2, 3 };
            arrgh[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int[] arrarrgh in arrgh)
            {
                foreach (int num in arrarrgh)
                {
                    Console.Write(num + " ");
                }
                Console.Write('\n');
            }
        }

        static void NoNegative()
        {
            var rng = new Random();
            int size = 99;
            int[] arrgh = new int[size];
            for (int i = 0; i < arrgh.Length; i++) { arrgh[i] = rng.Next(sbyte.MinValue, sbyte.MaxValue); }
            Console.WriteLine($"Initial array[{size}]: " + string.Join(' ', arrgh));
            int not_negative = 0;
            int not_real = 0;
            int not_odd = 0;
            int no_less_then_100 = 0;
            int no_smaller = sbyte.MaxValue;
            int no_bigger = sbyte.MinValue;
            foreach (int i in arrgh)
            {
                if (i > 0) { not_negative++; }
                else if (i == 0) { not_real++; };
                if (i != 0 && i % 2 == 0) { not_odd++; };
                if (i >= 100 || i <= -100) { no_less_then_100++; };
                if (no_smaller > i) { no_smaller = i; };
                if (no_bigger < i) { no_bigger = i; };
            }
            Console.WriteLine($"Positive numbers: {not_negative};\n" +
                $"Zeroes: {not_real};\n" +
                $"Even numbers (zeroes excluded): {not_odd};\n" +
                $"Three-digit numbers: {no_less_then_100};\n" +
                $"The biggest number: {no_bigger};\n" +
                $"The smallest number: {no_smaller}.\n");
        }

        static void NoNegativex2()
        {
            var rng = new Random();
            int size0 = 32;
            int size1 = 32;
            IntArrayx2 arrgh = new IntArrayx2(size0, size1);
            
            Console.WriteLine($"Initial array[{size0}x{size1}]: ");
            arrgh.print_like_it_is();
            int not_negative = 0;
            int not_real = 0;
            int not_odd = 0;
            int no_less_then_100 = 0;
            int no_smaller = sbyte.MaxValue;
            int no_bigger = sbyte.MinValue;
            for (int i = 0; i <= arrgh.first_order; i++)
            {
                for (int j = 0; j <= arrgh.second_order; j++)
                {
                    var el = int.Parse(arrgh[i, j]);
                    if (el > 0) { not_negative++; }
                    else if (el == 0) { not_real++; };
                    if (el != 0 && el % 2 == 0) { not_odd++; };
                    if (el >= 100 || el <= -100) { no_less_then_100++; };
                    if (no_smaller > el) { no_smaller = el; };
                    if (no_bigger < el) { no_bigger = el; };
                }
            }
            Console.WriteLine($"Positive numbers: {not_negative};\n" +
                $"Zeroes: {not_real};\n" +
                $"Even numbers (zeroes excluded): {not_odd};\n" +
                $"Three-digit numbers: {no_less_then_100};\n" +
                $"The biggest number: {no_bigger};\n" +
                $"The smallest number: {no_smaller}.\n");
        }

        static void SortArrayx2()
        {
            IntArrayx2 arrgh = new IntArrayx2(4, 8);
            Console.WriteLine("Initial array: ");
            arrgh.print_like_it_is();
            arrgh.sort();

            Console.WriteLine("Sorted array: ");
            arrgh.print_like_it_is();
        }
    }
}
