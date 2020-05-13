using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisminterface
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon Display Dimension : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon Printer Printing....");
        }
    }
}
