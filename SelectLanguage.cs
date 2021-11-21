using System;
using System.IO;
using Newtonsoft.Json;
// using System.Collections.Generic;
// using Newtonsoft.Json.Linq;

class SelectLanguage {

    public Messages LoadJson(string language) {
        string fileName = language;
        string jsonString = File.ReadAllText(fileName);
        Messages messages = JsonConvert.DeserializeObject<Messages>(jsonString);
        
        return messages;
    }
    
}