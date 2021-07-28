
namespace TextToSpeech
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSelectVoice = new System.Windows.Forms.ComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnScenarioLoad = new System.Windows.Forms.Button();
            this.cbxSelectSpeech = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpeechAdd = new System.Windows.Forms.Button();
            this.btnNewScenario = new System.Windows.Forms.Button();
            this.lblScenarioTitle = new System.Windows.Forms.Label();
            this.btnEditSpeech = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveScenario = new System.Windows.Forms.Button();
            this.btnScenarioRun = new System.Windows.Forms.Button();
            this.trackBarRateChange = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRateValue = new System.Windows.Forms.Label();
            this.btnSpeechRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRateChange)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Głos: ";
            // 
            // cbxSelectVoice
            // 
            this.cbxSelectVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectVoice.FormattingEnabled = true;
            this.cbxSelectVoice.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna",
            "Neutralny"});
            this.cbxSelectVoice.Location = new System.Drawing.Point(95, 12);
            this.cbxSelectVoice.Name = "cbxSelectVoice";
            this.cbxSelectVoice.Size = new System.Drawing.Size(184, 21);
            this.cbxSelectVoice.TabIndex = 1;
            this.cbxSelectVoice.SelectedIndexChanged += new System.EventHandler(this.ChangeVoice);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(16, 75);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArea.Size = new System.Drawing.Size(761, 286);
            this.txtArea.TabIndex = 2;
            this.txtArea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tekst: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(689, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Zapisz do .wav";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(589, 369);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Odtwórz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(589, 398);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Zatrzymaj";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Stop);
            // 
            // btnScenarioLoad
            // 
            this.btnScenarioLoad.Location = new System.Drawing.Point(16, 396);
            this.btnScenarioLoad.Name = "btnScenarioLoad";
            this.btnScenarioLoad.Size = new System.Drawing.Size(150, 23);
            this.btnScenarioLoad.TabIndex = 7;
            this.btnScenarioLoad.Text = "Załaduj scenariusz";
            this.btnScenarioLoad.UseVisualStyleBackColor = true;
            this.btnScenarioLoad.Click += new System.EventHandler(this.LoadScenario);
            // 
            // cbxSelectSpeech
            // 
            this.cbxSelectSpeech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectSpeech.DropDownWidth = 80;
            this.cbxSelectSpeech.FormattingEnabled = true;
            this.cbxSelectSpeech.Location = new System.Drawing.Point(173, 396);
            this.cbxSelectSpeech.Name = "cbxSelectSpeech";
            this.cbxSelectSpeech.Size = new System.Drawing.Size(96, 21);
            this.cbxSelectSpeech.TabIndex = 8;
            this.cbxSelectSpeech.SelectedIndexChanged += new System.EventHandler(this.ChangeSpeech);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scenariusz: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSpeechAdd
            // 
            this.btnSpeechAdd.Location = new System.Drawing.Point(278, 369);
            this.btnSpeechAdd.Name = "btnSpeechAdd";
            this.btnSpeechAdd.Size = new System.Drawing.Size(218, 21);
            this.btnSpeechAdd.TabIndex = 10;
            this.btnSpeechAdd.Text = "Dodaj aktualny tekst do scenariusza";
            this.btnSpeechAdd.UseVisualStyleBackColor = true;
            this.btnSpeechAdd.Click += new System.EventHandler(this.AddNewSpeech);
            // 
            // btnNewScenario
            // 
            this.btnNewScenario.Location = new System.Drawing.Point(17, 367);
            this.btnNewScenario.Name = "btnNewScenario";
            this.btnNewScenario.Size = new System.Drawing.Size(149, 23);
            this.btnNewScenario.TabIndex = 11;
            this.btnNewScenario.Text = "Nowy scenariusz";
            this.btnNewScenario.UseVisualStyleBackColor = true;
            this.btnNewScenario.Click += new System.EventHandler(this.NewScenario);
            // 
            // lblScenarioTitle
            // 
            this.lblScenarioTitle.AutoSize = true;
            this.lblScenarioTitle.Location = new System.Drawing.Point(243, 459);
            this.lblScenarioTitle.Name = "lblScenarioTitle";
            this.lblScenarioTitle.Size = new System.Drawing.Size(64, 13);
            this.lblScenarioTitle.TabIndex = 12;
            this.lblScenarioTitle.Text = "nie wybrano";
            // 
            // btnEditSpeech
            // 
            this.btnEditSpeech.Location = new System.Drawing.Point(278, 396);
            this.btnEditSpeech.Name = "btnEditSpeech";
            this.btnEditSpeech.Size = new System.Drawing.Size(218, 23);
            this.btnEditSpeech.TabIndex = 13;
            this.btnEditSpeech.Text = "Zmień aktualną kwestię";
            this.btnEditSpeech.UseVisualStyleBackColor = true;
            this.btnEditSpeech.Click += new System.EventHandler(this.EditSpeech);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kwestia:";
            // 
            // btnSaveScenario
            // 
            this.btnSaveScenario.Location = new System.Drawing.Point(16, 425);
            this.btnSaveScenario.Name = "btnSaveScenario";
            this.btnSaveScenario.Size = new System.Drawing.Size(149, 30);
            this.btnSaveScenario.TabIndex = 15;
            this.btnSaveScenario.Text = "Zapisz scenariusz";
            this.btnSaveScenario.UseVisualStyleBackColor = true;
            this.btnSaveScenario.Click += new System.EventHandler(this.SaveScenario);
            // 
            // btnScenarioRun
            // 
            this.btnScenarioRun.Location = new System.Drawing.Point(645, 459);
            this.btnScenarioRun.Name = "btnScenarioRun";
            this.btnScenarioRun.Size = new System.Drawing.Size(130, 23);
            this.btnScenarioRun.TabIndex = 16;
            this.btnScenarioRun.Text = "Odtwórz scenariusz";
            this.btnScenarioRun.UseVisualStyleBackColor = true;
            this.btnScenarioRun.Click += new System.EventHandler(this.Scenario_Run);
            // 
            // trackBarRateChange
            // 
            this.trackBarRateChange.Location = new System.Drawing.Point(470, 459);
            this.trackBarRateChange.Minimum = -10;
            this.trackBarRateChange.Name = "trackBarRateChange";
            this.trackBarRateChange.Size = new System.Drawing.Size(169, 45);
            this.trackBarRateChange.TabIndex = 17;
            this.trackBarRateChange.ValueChanged += new System.EventHandler(this.trackBarRateChange_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prędkość:";
            // 
            // lblRateValue
            // 
            this.lblRateValue.AutoSize = true;
            this.lblRateValue.Location = new System.Drawing.Point(437, 464);
            this.lblRateValue.Name = "lblRateValue";
            this.lblRateValue.Size = new System.Drawing.Size(13, 13);
            this.lblRateValue.TabIndex = 19;
            this.lblRateValue.Text = "0";
            // 
            // btnSpeechRemove
            // 
            this.btnSpeechRemove.Location = new System.Drawing.Point(278, 425);
            this.btnSpeechRemove.Name = "btnSpeechRemove";
            this.btnSpeechRemove.Size = new System.Drawing.Size(218, 23);
            this.btnSpeechRemove.TabIndex = 20;
            this.btnSpeechRemove.Text = "Usuń aktualną kwestię";
            this.btnSpeechRemove.UseVisualStyleBackColor = true;
            this.btnSpeechRemove.Click += new System.EventHandler(this.btnSpeechRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.Controls.Add(this.btnSpeechRemove);
            this.Controls.Add(this.lblRateValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarRateChange);
            this.Controls.Add(this.btnScenarioRun);
            this.Controls.Add(this.btnSaveScenario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditSpeech);
            this.Controls.Add(this.lblScenarioTitle);
            this.Controls.Add(this.btnNewScenario);
            this.Controls.Add(this.btnSpeechAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSelectSpeech);
            this.Controls.Add(this.btnScenarioLoad);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.cbxSelectVoice);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Windows Speech Manager";
            this.Click += new System.EventHandler(this.Form_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_keypress);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRateChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSelectVoice;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnScenarioLoad;
        private System.Windows.Forms.ComboBox cbxSelectSpeech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpeechAdd;
        private System.Windows.Forms.Button btnNewScenario;
        private System.Windows.Forms.Label lblScenarioTitle;
        private System.Windows.Forms.Button btnEditSpeech;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveScenario;
        private System.Windows.Forms.Button btnScenarioRun;
        private System.Windows.Forms.TrackBar trackBarRateChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRateValue;
        private System.Windows.Forms.Button btnSpeechRemove;
    }
}