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

            EmailServices emailServices = new EmailServices();
            UploadServices uploadServices = new UploadServices();
            encoder.VideoEncoded += emailServices.OnVideoEncoded;
            encoder.VideoEncoded += uploadServices.OnVideoEncoded;
            encoder.EncodeVideo(new Video() { Title = "youtube shorts" });

            //encoder.VideoEncoded += 
        }
    }
}