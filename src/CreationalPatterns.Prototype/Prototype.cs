using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Prototype
{
    [Serializable()]
    public class Prototype : IPrototype<Prototype>
    {
        // Content members
        public string Country { get; set; }
        public string Capital { get; set; }
        private DeeperData Language { get; set; }

        public Prototype(string country, string capital, string language)
        {
            Country = country;
            Capital = capital;
            Language = new DeeperData(language);
        }
        public void SetLanguage(string languageName)
        {
            Language = new DeeperData(languageName);
        }

        public override string ToString()
        {
            return Country + "\t\t" + Capital + "\t\t->" + Language;
        }
    }

    [Serializable()]
    public class PrototypeManager : IPrototype<Prototype>
    {
        public Dictionary<string, Prototype> prototypes = new Dictionary<string, Prototype> 
         {
            {"Germany", new Prototype ("Germany", "Berlin", "German")},
            {"Italy", new Prototype ("Italy", "Rome", "Italian")},
            {"Australia", new Prototype ("Australia", "Canberra", "English")}
         };
    }

}
