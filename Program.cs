using System;
using HW_3_4.interfaces;
using HW_3_4.classes.value_givers;
using HW_3_4.classes;
namespace HW_3_4
{
    class Program
    {
        static void Main()
        {
            IPrinter[] array = new IPrinter[8];

            Int_giver ints = new();
            String_giver strings = new();
            Bool_giver bools = new();
            Double_giver doubles = new();
            
            //one_dim

            Console.WriteLine("Введите длину одномерного массива:");
            int len_d1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool fill_rand = bool.Parse(Console.ReadLine());

            one_dim<int> int_one_dim = new(ints, len_d1,fill_rand);
            array[0] = int_one_dim;
            Console.WriteLine();
            one_dim<string> string_one_dim = new(strings, len_d1,fill_rand);
            Console.WriteLine();
            array[1] = string_one_dim;
            one_dim<double> double_one_dim = new(doubles, len_d1, fill_rand);
            array[2] = double_one_dim;
            Console.WriteLine();
            one_dim<bool> bool_one_dim = new(bools, len_d1, fill_rand);
            array[3] = bool_one_dim;
            Console.WriteLine();

            // two_dim
            
            Console.WriteLine("Введите высоту двумерного массива");
            int high_d2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину двумерного массива");
            int len_d2 = int.Parse(Console.ReadLine());

            two_dim<int> int_two_dim = new(ints, high_d2, len_d2, fill_rand);
            array[4] = int_two_dim;
            two_dim<string> string_two_dim = new(strings, high_d2, len_d2, fill_rand);
            array[5] = string_two_dim;
            two_dim<double> double_two_dim = new(doubles, high_d2, len_d2, fill_rand);
            array[6] = double_two_dim;
            two_dim<bool> bool_two_dim = new(bools, high_d2, len_d2, fill_rand);
            array[7] = bool_two_dim;
        }
    }
}