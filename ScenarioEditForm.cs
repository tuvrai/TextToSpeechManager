using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToSpeech
{
    public partial class ScenarioEditForm : Form
    {
        private CurrentState cs;
        public ScenarioEditForm(ref CurrentState cs)
        {
            InitializeComponent();
            this.cs = cs;
            this.listBoxSpeechList.DataSource = new BindingList<Speech>(cs.Get().SpeechList);
            this.listBoxSpeechList.DisplayMember = "Title";
            txtScenarioTitleInput.Text = cs.Get().Name;
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            try
            {
                int id = listBoxSpeechList.SelectedIndex;
                cs.Get().MoveDown(listBoxSpeechList.SelectedIndex);
                listBoxSpeechList.DataSource = new BindingList<Speech>(cs.Get().SpeechList);
                listBoxSpeechList.SelectedIndex = id + 1;
            }
            catch
            {
                return;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            try
            {
                int id = listBoxSpeechList.SelectedIndex;
                cs.Get().MoveUp(listBoxSpeechList.SelectedIndex);
                listBoxSpeechList.DataSource = new BindingList<Speech>(cs.Get().SpeechList);
                listBoxSpeechList.SelectedIndex = id-1;
            }
            catch
            {
                return;
            }
        }

        private void ScenarioEditForm_Deactivate(object sender, EventArgs e)
        {
            cs.Get().Name = txtScenarioTitleInput.Text;
        }

        private void listBoxSpeechList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Speech item = cs.Get().SpeechList[listBoxSpeechList.SelectedIndex];
            lblSpeechText.Text = item.Text;
            txtCurrentSpeechName.Text = item.Title;
        }

        private void txtCurrentSpeechName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSpeechNameConfirm_Click(object sender, EventArgs e)
        {
            cs.Get().SpeechList[listBoxSpeechList.SelectedIndex].Title = txtCurrentSpeechName.Text;
            listBoxSpeechList.DataSource = new BindingList<Speech>(cs.Get().SpeechList);
        }
    }
}
