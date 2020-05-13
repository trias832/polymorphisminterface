using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisminterface
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Laserjet Display Dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("Laserjet Printer Printing....");
        }
    }
}
