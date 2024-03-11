using System;
using HW_3_4.interfaces;
namespace HW_3_4.classes.value_givers
{
    class Double_giver : Ivalue_giver<double>
    {
        Random rnd = new Random();
        public double Get_Random()
        {
            return rnd.NextDouble();
        }

        public double Get_Manual()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}