using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XMLDom.ChuongTrinh
{
    internal class DocPhanSo
    {
        private int tuSo, mauSo;
        private string duongDan = Directory.GetCurrentDirectory() + @"..\..\..\DuLieu\PhanSo.xml";

        public void PhanSo()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(duongDan);

            XmlElement goc;
            goc = xmlDocument.DocumentElement;

            tuSo = int.Parse(goc.GetAttribute("Tu_So"));
            mauSo = int.Parse(goc.GetAttribute("Mau_So"));

            Console.WriteLine($"Phân số là: {tuSo}/{mauSo}");
        }
    }
}