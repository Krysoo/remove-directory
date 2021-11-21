using System;
using System.IO;
using Newtonsoft.Json;

class LookForProgram : SelectLanguage {
    
    public bool findFolder(string name, string dir, string lang) {
        
  
        string[] foldersinDir = System.IO.Directory.GetDirectories(dir, "*", new EnumerationOptions {
            IgnoreInaccessible = true,
            RecurseSubdirectories = true
        });

        bool didFind = false;

        foreach(string path in foldersinDir) {
            
            if (path.Contains(name, StringComparison.OrdinalIgnoreCase)) {

                Console.WriteLine(LoadJson(lang).findedFile + name + " ! " + LoadJson(lang).location  + path);
                Console.WriteLine(LoadJson(lang).isRightPath);

                char sciezka = Convert.ToChar(Console.ReadLine());
                if (sciezka.Equals('y')) {
                    didFind = true;
                    Console.WriteLine(LoadJson(lang).isRightFile);
                    char ifSure = Convert.ToChar(Console.ReadLine());
                    if (ifSure.Equals('y')) {
                        deleteDir delete = new deleteDir();
                        return delete.getRidOfDirectory(path);
                    } else return false;
                }
            }
        } //end of foreach
        if (!didFind) {
            Console.WriteLine(LoadJson(lang).didntFindFile);
            findFolder(name, "d:/", lang);
        } return false;
    }

    public LookForProgram(string name, string language) {
        if (findFolder(name, "c:/", language)) {
            Console.WriteLine(LoadJson(language).findedAndDeleted + name);  
        } else {
            Console.WriteLine(LoadJson(language).didntDeleteFile);
        }
    }
}