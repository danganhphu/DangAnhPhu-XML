using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace BaiTap1
{
    internal class DonThuc
    {
        private int heSo, soMu, x;
        private string duongDan = Directory.GetCurrentDirectory() + @"..\..\..\DuLieu\DonThuc.xml";

        public void TinhDonThuc()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(duongDan);

            XmlElement goc;
            goc = xmlDocument.DocumentElement;

            heSo = int.Parse(goc.GetAttribute("He_So"));
            soMu = int.Parse(goc.GetAttribute("So_Mu"));

            Console.WriteLine($"Đơn thức là: {heSo}*X^{soMu}");
            Console.Write("Nhập giá trị x: ");
            while (int.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("Nhập sai giá trị x. Nhập lại: ");
            }

            Console.WriteLine($"Giá trị của x = {x}");
            float giaTri = (float)(heSo * Math.Pow(x, soMu));
            Console.Write($"Kết quả là: {giaTri}");
        }
    }
}