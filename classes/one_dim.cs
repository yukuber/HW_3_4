using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes{

sealed class one_dim<T> : Parent<T>
{
    private T[] array;

    private int len_one_dim;

    public one_dim (Ivalue_giver<T> value_giver, int len_one_dim, bool fill_rand = false) : base(value_giver, fill_rand)
    {
        this.len_one_dim = len_one_dim;
        array = new T[len_one_dim];
        Create();
        Print();
    }
    
    public override void Create()
    {
        base.Create();
    }
    
    protected override void Rand()
    {
        for (int i = 0; i<len_one_dim;i++)
        {
            array[i] = value_giver.Get_Random();
        }
    }   
   
    protected override void Manual()
    {
        for (int i = 0; i<len_one_dim; i++)
        {
            array[i] = value_giver.Get_Manual();
        }
    }
          

    public override void Print()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }         
    }
}
}