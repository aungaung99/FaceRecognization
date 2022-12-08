using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognization4._0
{
    class Config
    {
        public static string FaceListTextFile = "TrainedImages\\FaceList.txt";
        public static string HaarCascadePath = @"C:\haarcascades\haarcascade_frontalface_alt_tree.xml";
        public static string FacePhotosPath = Directory.GetCurrentDirectory() + @"\TrainedImages";
        public static string ImageFileExtension = ".bmp";
    }
}
