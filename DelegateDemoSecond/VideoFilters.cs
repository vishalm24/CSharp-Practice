using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoSecond
{
    internal class VideoFilters
    {
        public void ApplyBrightness(Video video)
        {
            Console.WriteLine("Applying Brightness");
        }
        public void ApplyContrast(Video video)
        {
            Console.WriteLine("Applying Contrast");
        }
        public void Resize(Video video)
        {
            Console.WriteLine("Resizing Photograph");
        }
    }
}
