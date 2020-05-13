using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisminterface
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson Display Dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson Printer Printing....");
        }
    }
}
