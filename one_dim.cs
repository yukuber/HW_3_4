using System;

class one_dim : Parent, Ione_dim//класс одномерного массива
{
    private int[] array;

    public int Length
    {
        get { return array.Length}
    }
    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }

    public one_dim (int len_one_dim, bool fill_rand = false) : base(fill_rand)
    {
        ReCreate(fill_rand);
    }
    
    
    protected override void Rand()
    {
        for (int i = 0; i<array.Length;i++)
        {
            array[i] = rnd.Next(-100,100);
        }
    }
    public override void ReCreate (bool fill_rand)
    {
        base.ReCreate();
    }
    protected override void Manual()
    {
        for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine($"значение {i}:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
    }
    public override void Print()
    {
        Print(array);
    }
    public override double Average() //вычисление среднего арифметического 
    {
        double sam = 0;
        foreach(int elem in array)
        {
            sam+=elem;
        }
        return sam/array.Length;
    }
        

    private static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == int.MinValue)
            {
                continue;
            }
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();            
    }
        
    public void non_repeat()
    {
        int[] unique = array.Distinct().ToArray();
        Print(unique);
    }
}