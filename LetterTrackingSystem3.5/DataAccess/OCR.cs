using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODI;
using System.IO;

namespace LetterTrackingSystem.DataAccess
{
    public class OCR
    {
        public string ExtractTextFromImage(string filePath)
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
