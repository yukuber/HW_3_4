using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes;
abstract class Parent<T> : IParent, IPrinter  
{
    protected Ivalue_giver<T> value_giver;
    protected bool fill_rand = false;
    public static Random rnd = new Random();
    protected Parent(Ivalue_giver<T> value_giver, bool fill_rand)
    {
        this.value_giver = value_giver;
        this.fill_rand = fill_rand;
        Create();

    }

    public virtual void Create()
    {
        if (fill_rand)
        {
            Manual();
        }
        else
        {
            Rand();
        }
    }

    protected abstract void Rand();

    protected abstract void Manual();
    
    public abstract void Print();
}
