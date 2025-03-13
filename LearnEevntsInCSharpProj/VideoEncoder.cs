using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearnEevntsInCSharpProj
{
    public class VideoEventArgs : EventArgs
    {
        public List<string> EncodedVideosList = new List<string>() ;
       public VideoEventArgs(string str1) { 
        EncodedVideosList.AddRange(str1.Split(" ")) ;
        }
    }
    public class VideoEncoder
    {
        // 1 define  a delegate - may use built in delegates here 
        // 2 define an event based on that delegate 
        // 3 raise the event 

        public delegate void VideoEncodedEventHandler(VideoEncoder source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

       
        public static string EncodedVideoDetails { get; set; }
        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding {0} video",video.Title);
            EncodedVideoDetails = video.Title;

            Thread.Sleep(2000);

            AfterEncoding(video.Title);
        }

        protected virtual void AfterEncoding(string title)
        {
            if (VideoEncoded != null)
            {
                Console.WriteLine(" {0} encoded successfully",title);
                VideoEncoded(this, new VideoEventArgs(title));
            }
        }
    }
}
