using System;  // Importing the System namespace for basic functionalities
using System.Collections.Generic; // Importing List<T> for storing encoded video titles
using System.Threading; // Importing Thread to simulate encoding delay

namespace LearnEevntsInCSharpProj
{
    // Custom EventArgs class to hold encoded video details
    public class VideoEventArgs : EventArgs
    {
        // List to store the names of encoded videos
        public List<string> EncodedVideosList = new List<string>();

        // Constructor: Takes a string of video names separated by space and splits them into a list
        public VideoEventArgs(string str1) 
        { 
            EncodedVideosList.AddRange(str1.Split(" ")); 
        }
    }

    // VideoEncoder class responsible for video encoding and event handling
    public class VideoEncoder
    {
        // Step 1: Define a delegate that specifies the signature of the event handler
        public delegate void VideoEncodedEventHandler(VideoEncoder source, VideoEventArgs args);

        // Step 2: Define an event based on the delegate
        public event VideoEncodedEventHandler VideoEncoded;

        // Static property to store encoded video details
        public static string EncodedVideoDetails { get; set; }

        // Method to encode a video (simulated with Thread.Sleep for delay)
        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding {0} video", video.Title);
            EncodedVideoDetails = video.Title; // Store the encoded video title

            Thread.Sleep(2000); // Simulating video encoding time

            // Step 3: Raise the event after encoding is complete
            AfterEncoding(video.Title);
        }

        // Protected method to notify subscribers after encoding is completed
        protected virtual void AfterEncoding(string title)
        {
            if (VideoEncoded != null) // Check if there are any subscribers to the event
            {
                Console.WriteLine(" {0} encoded successfully", title);

                // Raising the event and passing the encoded video title as an argument
                VideoEncoded(this, new VideoEventArgs(title));
            }
        }
    }
}
