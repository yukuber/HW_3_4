using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes{
sealed class two_dim<T> : Parent<T>
{

    private T[,] array;
    private int high_d2;
    private int len_d2;

    public two_dim(Ivalue_giver<T> value_giver, int high_d2, int len_d2, bool fill_rand = false) : base(value_giver, fill_rand)
    {
        this.high_d2 = high_d2;
        this.len_d2 = len_d2;
        array = new T[high_d2,len_d2];
        Create();
        Print();
    }

    public override void Create()
    {
        base.Create();
    }

    protected override void Rand()
    {
        for (int i = 0; i < high_d2; i++)
        {
            for (int j = 0; j < len_d2; j++)
            {
                array[i, j] =  value_giver.Get_Random();
            }
        }
    }
    protected override void Manual()
    {
        for (int i = 0; i < high_d2; i++)
        {
            for (int j = 0; j < len_d2; j++)
            {
                array[i,j] = value_giver.Get_Manual();
            }
        }
    }
    public override void Print()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
}