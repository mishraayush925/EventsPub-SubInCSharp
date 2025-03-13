using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEevntsInCSharpProj
{
    public class UploadServices
    {
        public void OnVideoEncoded(VideoEncoder source , EventArgs e)
        {
            Console.WriteLine("Uploading the encoded video now : {0 }" ,VideoEncoder.EncodedVideoDetails);
        }
    }
}
