using System;
using HW_3_3.interfaces;
namespace HW_3_3.classes;
class three_dim : Parent, Ijagged_dim
{


    private int[][] array;

    public three_dim(int high_three_dim, bool fill_rand = false) : base(fill_rand)
    {
        array = new int[high_three_dim][];
        ReCreate(fill_rand);
    }

    public override void ReCreate(bool fill_rand)
    {

        base.ReCreate(fill_rand);
    }
    
    protected override void Rand()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < rnd.Next(1, 10); j++)
            {
                array[i][j] = rnd.Next(-100, 100);
            }
        }
    }

    protected override void Manual()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"введите значение элемента {i}");
            int len_each_three_dim = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < len_each_three_dim; j++)
            {
                Console.Write($"элемент [{i}],[{j}]: ");
                array[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public override double Average()
    {
        int sam = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                sam += array[i][j];
            }
        }
        return sam/array.Length;
    }

    public void average_each_three_dim()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += j;
                Console.WriteLine($"среднее значение в подмассиве {i} = {sum / array[i].Length}");
            }
        }
    }

    public void muliply_three_dim()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.WriteLine("");
                if (j % 2 == 0)
                {
                    Console.Write(i * j);
                }
                else
                {
                    Console.Write(array[i][j]);
                }
            }
        }
    }

    public override void Print()
    {
        Print(array);
    }

    private static void Print(int[][] array3)
    {
        for (int i = 0; i<array3.Length; i++)
        {
            for (int j = 0; j <array3[i].Length;j++)
            {
                if (array3[i][j] == int.MinValue)
                {
                    continue;
                }
                Console.Write($"{array3[i][j]} ");            
            }
            Console.WriteLine();            
        }
    }
}
