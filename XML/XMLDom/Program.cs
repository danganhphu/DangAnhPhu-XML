using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ChuongTrinh.DocPhanSo ps = new ChuongTrinh.DocPhanSo();
            ps.PhanSo();

            Console.ReadKey();
        }
    }
}