using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace HospitalManagementSystem.Helpers
{
    public class ImageConvertor
    {
        public byte[] ImageStream { get; set; }
        public BitmapFrame ImageSource { get; set; }
        public void ConvertPhotoToByteArray(string imagepath)
        {
            FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            byte[] photo_aray = new byte[fs.Length];
            fs.Read(photo_aray, 0, photo_aray.Length);
            ImageStream = photo_aray;
        }
        public void ConvertByteArrayToPhot(byte[] byteArray)
        {
            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                ImageSource = BitmapFrame.Create(stream, BitmapCreateOptions.None,
                                                   BitmapCacheOption.OnLoad);
            }
        }
    }
}
