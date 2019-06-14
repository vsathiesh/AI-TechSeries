using System;
using AI_TechSeries.AI.Demo.Speech;

namespace SpeechToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speech To Text");
            SpeechRecognitionSamples.SpeechContinuousRecognitionUsingCustomizedModelAsync().Wait();
        }
    }
}
