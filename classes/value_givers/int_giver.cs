using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes.value_givers
{
    class Int_giver : Ivalue_giver<int>
    {
        Random rnd = new Random();
        public int Get_Random()
        {
            return rnd.Next(100);
        }

        public int Get_Manual()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}