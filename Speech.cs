﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextToSpeech
{
    [XmlRoot]
    public class Speech
    {
        public string Title { get; set; }
        public string Text { get; set; } = "";
        public string VoiceName { get; set; }
        public int Rate { get; set; } = 0;
    }
}
