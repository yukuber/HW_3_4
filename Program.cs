using System;

static void Main()
{
    IParent[] array = new IParent[3];

    //one_dim

    Console.WriteLine("Введите длину одномерного массива:");
    int len_d1 = int.Parse(Console.ReadLine());

    one_dim array1 = new one_dim(len_d1);

    array1.Average();
    array1.non_repeat();

    // two_dim
    
    Console.WriteLine("Введите высоту двумерного массива");
    int high_d2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину двумерного массива");
    int len_d2 = int.Parse(Console.ReadLine());

    two_dim array2 = new(high_d2, len_d2);

    array2.Average();
    array2.obr_chet();

    //jagged_dim

    Console.WriteLine("Введите длину ступенчатого массива");
    int high_d3 = int.Parse(Console.ReadLine());

    three_dim array3 = new(high_d3);

    array3.Average();
    array3.average_each_three_dim();
    array3.muliply_three_dim();
    array3.Print();

    
    array[0] = array1;
    array[1] = array2;
    array[2] = array3;

    for (int i = 0; i < 3; i++)
    {
        array[i].Print();
        Console.Write("Среднее значение: ");
        Console.WriteLine(array[i].Average());
        Console.WriteLine();
    }

	IPrinter printer = new Weeks();
	Console.WriteLine("Дни недели:");
	IPrinter.Print();    
}
