Imports System.Xml

Module DocPhanSo

    Public Sub Main()
        Dim TuSo, MauSo As Integer
        Dim DuongDan As String = "..\..\..\DuLieu\PhanSo.xml"
        Dim TaiLieu As New XmlDocument
        TaiLieu.Load(DuongDan)
        Dim Goc As XmlElement = TaiLieu.DocumentElement
        TuSo = Goc.GetAttribute("Tu_So")
        MauSo = Goc.GetAttribute("Mau_So")

        Dim Chuoi As String = "Phan so: "
        Chuoi &= TuSo & "/" & MauSo
        Console.WriteLine(Chuoi)
        Console.ReadLine()
    End Sub

End Module