using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextToSpeech
{
    [XmlRoot]
    public class Speech
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Text { get; set; } = "";
        public string VoiceName { get; set; }
        public int Rate { get; set; } = 0;
    }
}
