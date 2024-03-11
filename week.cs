using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Weeks: IPrinter
{
  void IPrinter.Print()        
  {
    foreach (weeks i in Enum.GetValues(typeof(weeks)))
    {
      Console.WriteLine(i);
    }      
    Console.WriteLine();
  }
  
  enum weeks {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
    }
}
