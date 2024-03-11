using System;

class one_dim : Parent, Ione_dim
{
    private int[] array;
    protected int len_one_dim;

    public one_dim (int len_one_dim, bool fill_rand = false) : base(fill_rand)
    {
        ReCreate(fill_rand);
    }
    
     public override void ReCreate (bool fill_rand)
    {
        int[] array = new array[len_one_dim];
        base.ReCreate();
    }
    
    protected override void Rand()
    {
        for (int i = 0; i<array.Length;i++)
        {
            array[i] = rnd.Next(-100,100);
        }
    }
   
    protected override void Manual()
    {
        for (int i = 0; i<array.Length; i++)
        {
            Console.WriteLine($"элемент {i}:");
            int x = int.Parse(Console.ReadLine());
            array[i] = x;
        }
    }
    
    public override void Print()
    {
        Print(array);
    }
    public override double Average()
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
