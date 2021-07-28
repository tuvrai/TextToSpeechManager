using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;
using System.Windows.Forms;

namespace TextToSpeech
{
    public class Voicer
    {
        private SpeechSynthesizer Voice;
        public SpeechSynthesizer getVoice()
        {
            return Voice;
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Voicer()
        {
            Voice = new SpeechSynthesizer();
            Text = "";
        }
        public List<string> VoiceList
        {
            get
            {
                List<string> listvoices = new List<string>();
                foreach (InstalledVoice voice in Voice.GetInstalledVoices())
                {
                    listvoices.Add(voice.VoiceInfo.Name);
                }
                return listvoices;
            }
        }
        public void SetVoice(string name)
        {
            Voice.SelectVoice(name);
        }
        public void Start()
        {
            CancelAll();
            Voice.SpeakAsync(Text);
        }
        public void CancelAll()
        {
            Voice.SpeakAsyncCancelAll();
        }
        public bool ChangeState()
        {
            if (Voice.State.Equals(SynthesizerState.Paused)) { Voice.Resume(); return true; }
            else if (Voice.State.Equals(SynthesizerState.Speaking)) { Voice.Pause(); return false; }
            return false;
        }
        public void Resume()
        {
            Voice.Resume();
        }
        public void StreamToWav(FileStream fs)
        {
            Voice.SetOutputToWaveStream(fs);
            Voice.Speak(Text);
        }
        public void StreamToAudio()
        {
            Voice.SetOutputToDefaultAudioDevice();
        }
        public SynthesizerState GetState()
        {
            return Voice.State;
        }
        public bool IsStarted = false;

        internal void SetRate(int value)
        {
            Voice.Rate = value;
        }
    }
}
