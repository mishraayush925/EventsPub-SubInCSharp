using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearnEevntsInCSharpProj
{
    public class VideoEncoder
    {
        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding {0} video",video.Title);

            Thread.Sleep(2000);

            Console.WriteLine("Video {0} encoded ",video.Title);
        }
    }
}
