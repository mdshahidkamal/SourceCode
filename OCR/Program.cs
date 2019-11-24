using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODI;
using System.IO;

namespace OCR
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\user\Desktop\Test.jpg";
            //string extractText = ExtractTextFromImage(filePath);
            Console.WriteLine("ehllo");
            //Console.WriteLine(extractText);
            Console.ReadLine();
        }
        static string ExtractTextFromImage(string filePath)
        {
            Document modiDocument = new Document();
            modiDocument.Create(filePath);
            modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
            MODI.Image modiImage = (modiDocument.Images[0] as MODI.Image);
            string extractedText = modiImage.Layout.Text;
            modiDocument.Close();
            return extractedText;
        }
    }
}
