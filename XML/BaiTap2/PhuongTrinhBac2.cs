using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace BaiTap2
{
    internal class PhuongTrinhBac2
    {
        private int a, b, c;
        private string duongDan = Directory.GetCurrentDirectory() + @"..\..\..\DuLieu\TamThuc.xml";

        //lấy giá trị từ xml
        public void DocDL()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(duongDan);

            XmlElement goc;
            goc = xmlDocument.DocumentElement;

            a = int.Parse(goc.GetAttribute("a"));
            b = int.Parse(goc.GetAttribute("b"));
            c = int.Parse(goc.GetAttribute("c"));

            Console.WriteLine($"Phương trình bậc 2 là: {a}x^2 + {b}x + {c} = 0");
        }

        //Giải pt
        public void GiaiPTB2()
        {
            float delta;
            delta = (b / 2) * (b / 2) - a * c;

            Console.WriteLine($"Delta phẩy = {delta}");

            if (delta < 0)
            {
                Console.Write("No Solutions.");
            }
            else if (delta == 0)
            {
                float x;
                x = (-b / 2) / a;
                Console.Write($"Phương trình có nghiệm kép x1 = x2 = {x}");
            }
            else
            {
                double x1, x2;
                x1 = Math.Round(((-b / 2) + Math.Sqrt(delta)) / a, 3);
                x2 = Math.Round(((-b / 2) - Math.Sqrt(delta)) / a, 3);

                Console.Write($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}