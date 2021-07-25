using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TextToSpeech
{
    public class Scenario
    {
        public string Name { get; set; }
        public List<Speech> SpeechList { get; set; }

        [XmlIgnore]
        public List<String> SpeechesTitles
        {
            get
            {
                List<string> titles = new List<string>();
                if (SpeechList is null || SpeechList.Count <= 0) return titles;
                foreach (var speech in SpeechList)
                {
                    titles.Add(speech.Title);
                }
                return titles;
            }
        }

        [XmlIgnore]
        public int GetSize
        {
            get
            {
                return SpeechesTitles.Count;
            }
        }

        public void Save(string filename)
        {
            using (var stream = new FileStream(filename,FileMode.Create))
            {
                var xmlfile = new XmlSerializer(typeof(Scenario));
                xmlfile.Serialize(stream, this);
            }
        }

        public Scenario()
        {
            SpeechList = new List<Speech>();
        }

        public Scenario(string title)
        {
            Name = title;
            SpeechList = new List<Speech>();
        }
    }
}
