using System;
using HW_3_4.interfaces;
namespace HW_3_4.classes.value_givers
{
    class String_giver: Ivalue_giver<string>
    {
        Random rnd = new();
        public string Get_Random()
        {
            string alph = "1234567890qwertyuiopasdfghjklzxcvbnm";
            string str = "";
            for (int i = 0; i < rnd.Next(10); i++)
            {
                str += alph[rnd.Next(alph.Length)];
            }
            return str;
        }

        public string Get_Manual()
        {
            return Console.ReadLine();
        }
    }
}