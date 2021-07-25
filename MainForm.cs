using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Xml.Serialization;
using System.Timers;

namespace TextToSpeech
{
    
    public partial class MainForm : Form
    {
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();
            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

        private CurrentState currentState;
        private Voicer voicer;
        public MainForm()
        {
            KeyPreview = true;
            InitializeComponent();
            voicer = new Voicer();
            voicer.getVoice().SpeakCompleted += MainForm_SpeakCompleted;
            voicer.getVoice().SpeakStarted += MainForm_SpeakStarted;
            //Scenario scenario = new Scenario();
            //currentState = new CurrentState(scenario);
            currentState = new CurrentState();
            cbxSelectVoice.DataSource = voicer.VoiceList;

        }

        private void MainForm_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            voicer.IsStarted = true;
        }

        private void MainForm_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            voicer.IsStarted = false;
            if (currentState.IsScenarioStarted)
            {
                try
                {
                    cbxSelectSpeech.SelectedIndex += 1;
                }
                catch
                {
                    currentState.IsScenarioStarted = false;
                    MessageBox.Show("Scenariusz zakończony.");
                    return;
                }
                //System.Threading.Thread.Sleep(1500);
                Start(null, null);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeVoice(object sender, EventArgs e)
        {
            voicer.SetVoice(cbxSelectVoice.SelectedValue.ToString());
        }

        private void Start(object sender, EventArgs e)
        {
            try
            {
                voicer.SetVoice(cbxSelectVoice.SelectedItem.ToString());
                voicer.SetRate(trackBarRateChange.Value);
                voicer.Text = txtArea.Text;
                voicer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stop(object sender, EventArgs e)
        {
            try
            {
                if (voicer.ChangeState())
                {
                    btnStop.Text = "Zatrzymaj";
                }
                else btnStop.Text = "Wznów";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            try
            {
                voicer.CancelAll();
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Wav files|*.wav";
                    dialog.Title = "Save recording";
                    if (dialog.ShowDialog()==DialogResult.OK)
                    {
                        FileStream fs = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write);
                        voicer.Text = txtArea.Text;
                        voicer.StreamToWav(fs);
                        fs.Close();
                        voicer.StreamToAudio();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadScenario(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML Files|*.xml";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;
                    Scenario loadedScenario = LoadFromFile(selectedFileName);
                    currentState = new CurrentState(loadedScenario);
                    lblScenarioTitle.Text = currentState.Title;
                    cbxSelectSpeech.DataSource = (List<string>)currentState.Get().SpeechesTitles;
                    cbxSelectSpeech.DropDownWidth = DropDownWidth(cbxSelectSpeech);
                    // currentState.SelectedSpeech = currentState.Get().SpeechesTitles[cbxSelectSpeech.SelectedIndex];

                    //txtArea.Text = loadedScenario.SpeechList.Find(x => x.Title == cbxSelectSpeech.SelectedItem.ToString()).Text;
                    txtArea.Text = currentState.CurrentText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewScenario(object sender, EventArgs e)
        {
            string promptTitle = Prompt.ShowDialog("Wpisz tytuł nowego scenariusza", "Zatytułuj nowy scenariusz");
            Scenario newscenario = new Scenario(promptTitle);

            currentState = new CurrentState(newscenario);
            cbxSelectSpeech.DataSource = currentState.Get().SpeechesTitles;
            int width = DropDownWidth(cbxSelectSpeech);
            if (width <= 0) width = 80;
            cbxSelectSpeech.DropDownWidth = width;
            lblScenarioTitle.Text = currentState.Title;
            

        }

        private void AddNewSpeech(object sender, EventArgs e)
        {
            if (currentState.Get() is null)
            {
                NewScenario(null,null);
            }
            string promptSpeechTitle = Prompt.ShowDialog("Wpisz nazwę nowej kwestii", "Nowa kwestia");
            string SpeechText = txtArea.Text;
            Speech newspeech = new Speech();
            newspeech.Text = SpeechText;
            newspeech.Title = promptSpeechTitle;
            newspeech.VoiceName = cbxSelectVoice.SelectedItem.ToString();
            newspeech.Rate = trackBarRateChange.Value;
            currentState.Get().SpeechList.Add(newspeech);
            cbxSelectSpeech.DataSource = currentState.Get().SpeechesTitles;

            int width = DropDownWidth(cbxSelectSpeech);
            if (width <= 0) width = 80;
            cbxSelectSpeech.DropDownWidth = width;
        }

        private void ChangeSpeech(object sender, EventArgs e)
        {
            //currentState.SelectedSpeech = currentState.Get().SpeechesTitles[cbxSelectSpeech.SelectedIndex];
            //Speech selected = currentState.Get().SpeechList.Find(x => x.Title == currentState.SelectedSpeech);
            Speech selected = currentState.Get().SpeechList[cbxSelectSpeech.SelectedIndex];
            currentState.SelectedSpeech = currentState.Get().SpeechesTitles[cbxSelectSpeech.SelectedIndex];
            txtArea.Text = currentState.CurrentText;
            cbxSelectVoice.SelectedItem = selected.VoiceName;
            trackBarRateChange.Value = selected.Rate;
        }

        private void EditSpeech(object sender, EventArgs e)
        {
            if (currentState.Get() is null) return;
            currentState.SelectedSpeech = currentState.Get().SpeechesTitles[cbxSelectSpeech.SelectedIndex];
            currentState.Get().SpeechList[cbxSelectSpeech.SelectedIndex].Text = txtArea.Text;
            currentState.Get().SpeechList[cbxSelectSpeech.SelectedIndex].VoiceName = (string)cbxSelectVoice.SelectedItem;
            currentState.Get().SpeechList[cbxSelectSpeech.SelectedIndex].Rate = trackBarRateChange.Value;
        }

        private Scenario LoadFromFile(string filename)
        {
            try
            {
                using (var stream = new FileStream(filename, FileMode.Open))
                {
                    var xml = new XmlSerializer(typeof(Scenario));
                    return (Scenario)xml.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void SaveScenario(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "xml files|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        var xmlfile = new XmlSerializer(typeof(Scenario));
                        xmlfile.Serialize(stream, currentState.Get());
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void form_keypress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txtArea.Focused) return;
            if (e.KeyChar >= 49 && e.KeyChar <= 57)
            {
                try
                {
                    cbxSelectSpeech.SelectedIndex = (e.KeyChar - 48) - 1;
                    return;
                }
                catch
                {
                    return;
                }
            }
            if (e.KeyChar == 32)
            {
                if (voicer.IsStarted)
                {
                    Stop(null, null);
                }
                else
                {
                    Start(null, null);
                }
            }
        }

        private void Form_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Scenario_Run(object sender, EventArgs e)
        {
            try
            {
                cbxSelectSpeech.SelectedIndex = 0;
                currentState.IsScenarioStarted = true;
                Start(null, null);
            }
            catch
            {
                return;
            }
            
        }

        private void trackBarRateChange_ValueChanged(object sender, EventArgs e)
        {
            int value = (sender as TrackBar).Value;
            voicer.SetRate(value);
            lblRateValue.Text = value.ToString();
        }
    }

    
}
