using System;
using AI_TechSeries.AI.Demo.Speech;

namespace TextBasedAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text Based Assistant");
            IntentRecognitionSamples.TextBasedAssistant().Wait();
        }
    }
}
