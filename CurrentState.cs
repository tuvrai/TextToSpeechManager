using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeech
{
    public class CurrentState
    {
        public Scenario scenario { get; set; } = null;
        public Scenario Get()
        {
            return scenario;
        }
        public string Title
        {
            get
            {
                if (scenario is null) return "brak tytułu";
                else return scenario.Name;
            }
        }
        private string selectedSpeech;
        public string SelectedSpeech
        {
            get
            {
                return selectedSpeech;
            }
            set
            {
                selectedSpeech = value;
            }
        }

        public string CurrentText
        {
            get
            {
                if (scenario is null || scenario.SpeechList is null || scenario.SpeechList.Count <= 0) return "";
                return scenario.SpeechList.Find(x => x.Title == selectedSpeech).Text;
            }
        }

        public bool IsScenarioStarted { get; set; } = false;

        public CurrentState(Scenario newscenario)
        {
            scenario = newscenario;
        }

        public CurrentState()
        {

        }
    }
}
