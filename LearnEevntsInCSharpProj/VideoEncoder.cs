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
        // 1 define  a delegate - may use built in delegates here 
        // 2 define an event based on that delegate 
        // 3 raise the event 

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding {0} video",video.Title);

            Thread.Sleep(2000);

            OnVideoEncoded(video.Title);
        }

        protected virtual void OnVideoEncoded(string title)
        {
            if (VideoEncoded != null)
            {
                Console.WriteLine("video {0}encoded successfully",title);
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
