using System;
using AI_TechSeries.AI.Demo.Speech;

namespace LanguageTranslation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Language Translation");
            TranslationSamples.TranslationWithMicrophoneAsync().Wait();
        }
    }
}
