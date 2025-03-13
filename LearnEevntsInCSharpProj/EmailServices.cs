using LearnEevntsInCSharpProj;

namespace LearnEventsInCSharpProj
{
    public class EmailServices
    {
        public void OnVideoEncoded(object source , VideoEventArgs e)
        {

            Console.WriteLine("sending an email for the  {0} ....", e.EncodedVideosList[0]);
        }
    }
}