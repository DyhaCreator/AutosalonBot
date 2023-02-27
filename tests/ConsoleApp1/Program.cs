using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test(10,10);
        }
    }
    public class Test
    {
        int x, y;
        public Test(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
