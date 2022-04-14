using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            PhuongTrinhBac2 ptb2 = new PhuongTrinhBac2();

            ptb2.DocDL();
            ptb2.GiaiPTB2();

            Console.ReadKey();
        }
    }
}