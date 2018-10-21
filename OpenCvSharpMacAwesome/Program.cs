using System;
using OpenCvSharp;

namespace OpenCvSharpMacAwesome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var vm = new Mat("image.png"))
            {
                Cv2.ImShow("test",vm);
                Cv2.WaitKey();
                Cv2.DestroyAllWindows();
            }
        }
    }
}