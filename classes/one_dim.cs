using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes;
class one_dim<Type> : Parent<Type>
{
    private int[] array;

    public one_dim (Ivalue_giver<Type> value_giver, int len_one_dim, bool fill_rand = false) : base(value_giver, fill_rand)
    {
        array = new int[len_one_dim];
        Create();
    }
    
    public override void Create()
    {
        base.Create();
    }
    
    protected override void Rand()
    {
        for (int i = 0; i<array.Length;i++)
        {
            array[i] = value_giver.Get_Random();
        }
    }   
   
    protected override void Manual()
    {
        for (int i = 0; i<array.Length; i++)
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
