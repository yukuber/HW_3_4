using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes;
sealed class two_dim<Type> : Parent<Type>
{

    private Type[,] array;

    public two_dim(Ivalue_giver<Type> value_giver, int high_d2, int len_d2, bool fill_rand = false) : base(value_giver, fill_rand)
    {
        array = new Type[high_d2,len_d2];
        Create();
    }

    public override void Create()
    {
        base.Create();
    }

    protected override void Rand()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] =  value_giver.Get_Random();
            }
        }
    }
    protected override void Manual()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
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
