using LearnEevntsInCSharpProj;
using System;
namespace LearnEventsInCSharpProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello from events");
            VideoEncoder encoder = new VideoEncoder();
            encoder.EncodeVideo(new Video() { Title = "first video" });

        }
    }
}