using System;
using AI_TechSeries.AI.Demo.Speech;


namespace CustomSpeech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speech recognition using customized model");
            SpeechRecognitionSamples.SpeechContinuousRecognitionUsingCustomizedModelAsync().Wait();
        }
    }
    }
