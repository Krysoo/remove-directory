// Dzialanie programu:
// Po wpisaniu aplikacji ktora chcemy usunac
// Program zacznie przeszukiwac foldery w partycjach w poszukiwaniu folderu
// ktory zawiera podana aplikacje.

using System;
using System.IO;

namespace csharp_project
{
    class Program : SelectLanguage
    {

        static void LoadProgram(string language) {
            SelectLanguage lang = new SelectLanguage();
            lang.LoadJson(language);
            Console.WriteLine(lang.LoadJson(language).welcomeMessage);
            string name = Convert.ToString(Console.ReadLine());
            LookForProgram l = new LookForProgram(name, language);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select language: PL or EN");
            string language = Convert.ToString(Console.ReadLine());
            if (language.Equals("pl", StringComparison.OrdinalIgnoreCase)) {
                LoadProgram("lang_pl.json");
            } else {
                LoadProgram("lang_en.json");
            }
        } 
    }
}