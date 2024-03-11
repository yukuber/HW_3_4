using System;
using HW_3_4.interfaces;

namespace HW_3_4.classes.value_givers
{
    class Bool_giver : Ivalue_giver<bool>
    {
        Random rnd = new Random();
        public bool Get_Random()
        {
            bool[] bools = { true, false };
            return bools[rnd.Next(bools.Length)];
        }

        public bool Get_Manual()
        {
            return bool.Parse(Console.ReadLine());
        }
    }
}