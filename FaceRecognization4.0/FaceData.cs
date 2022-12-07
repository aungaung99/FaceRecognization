using Emgu.CV;
using Emgu.CV.Structure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognization4._0
{
    class FaceData
    {
        public string PersonName { get; set; }
        public Image<Gray,Byte> FaceImage { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
