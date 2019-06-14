using System;
using AI_TechSeries.AI.Demo.Speech;

namespace VoiceBasedAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voivce Based Assistant");
            IntentRecognitionSamples.VoiceBasedAssistant().Wait();
        }
    }
}
