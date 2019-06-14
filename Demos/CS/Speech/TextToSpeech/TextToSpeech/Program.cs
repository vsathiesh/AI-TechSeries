using System;
using AI_TechSeries.AI.Demo.Speech;

namespace TextToSpeech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Language Translation");
            TextToSpeechSample.SynthesisToSpeakerAsync
                ().Wait();
        }
    }
}
