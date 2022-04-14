using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DonThuc donThuc = new DonThuc();
            donThuc.TinhDonThuc();

            Console.ReadKey();
        }
    }
}