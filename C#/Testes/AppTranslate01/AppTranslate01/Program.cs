using System;
using System.Threading.Tasks;
using System.Linq;
using GoogleTranslateFreeApi;



namespace AppTranslate01
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var translator = new GoogleTranslator();

            Language from = Language.Auto;
            Language to = GoogleTranslator.GetLanguageByName("Japanese");
          //TranslationResult result = await translator.TranslateLiteAsync("Hello. How are you?", from, to);
            TranslationResult result = await translator.TranslateLiteAsync("Hello. How are you?", from, to);
            //The result is separated by the suggestions and the '\n' symbols
            string[] resultSeparated = result.FragmentedTranslation;

            //You can get all text using MergedTranslation property
            string resultMerged = result.MergedTranslation;

            //There is also original text transcription
            string transcription = result.TranslatedTextTranscription; // Kon'nichiwa! Ogenkidesuka?
            Console.WriteLine("Ok");



        }
    }
}
