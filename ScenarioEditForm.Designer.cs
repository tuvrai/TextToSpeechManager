
namespace TextToSpeech
{
    partial class ScenarioEditForm
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
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.listBoxSpeechList = new System.Windows.Forms.ListBox();
            this.lblSpeechText = new System.Windows.Forms.TextBox();
            this.lblScenarioTitle = new System.Windows.Forms.Label();
            this.txtScenarioTitleInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentSpeechName = new System.Windows.Forms.TextBox();
            this.btnSpeechNameConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(42, 310);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(89, 26);
            this.btnMoveUp.TabIndex = 1;
            this.btnMoveUp.Text = "Przesuń w górę";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(155, 310);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(88, 26);
            this.btnMoveDown.TabIndex = 2;
            this.btnMoveDown.Text = "Przesuń w dół";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // listBoxSpeechList
            // 
            this.listBoxSpeechList.FormattingEnabled = true;
            this.listBoxSpeechList.Location = new System.Drawing.Point(42, 57);
            this.listBoxSpeechList.Name = "listBoxSpeechList";
            this.listBoxSpeechList.Size = new System.Drawing.Size(201, 225);
            this.listBoxSpeechList.TabIndex = 3;
            this.listBoxSpeechList.SelectedIndexChanged += new System.EventHandler(this.listBoxSpeechList_SelectedIndexChanged);
            // 
            // lblSpeechText
            // 
            this.lblSpeechText.Location = new System.Drawing.Point(261, 57);
            this.lblSpeechText.Multiline = true;
            this.lblSpeechText.Name = "lblSpeechText";
            this.lblSpeechText.ReadOnly = true;
            this.lblSpeechText.Size = new System.Drawing.Size(277, 225);
            this.lblSpeechText.TabIndex = 4;
            // 
            // lblScenarioTitle
            // 
            this.lblScenarioTitle.AutoSize = true;
            this.lblScenarioTitle.Location = new System.Drawing.Point(39, 23);
            this.lblScenarioTitle.Name = "lblScenarioTitle";
            this.lblScenarioTitle.Size = new System.Drawing.Size(105, 13);
            this.lblScenarioTitle.TabIndex = 5;
            this.lblScenarioTitle.Text = "Nazwa scenariusza: ";
            // 
            // txtScenarioTitleInput
            // 
            this.txtScenarioTitleInput.Location = new System.Drawing.Point(143, 20);
            this.txtScenarioTitleInput.Name = "txtScenarioTitleInput";
            this.txtScenarioTitleInput.Size = new System.Drawing.Size(143, 20);
            this.txtScenarioTitleInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa kwestii: ";
            // 
            // txtCurrentSpeechName
            // 
            this.txtCurrentSpeechName.Location = new System.Drawing.Point(126, 285);
            this.txtCurrentSpeechName.Name = "txtCurrentSpeechName";
            this.txtCurrentSpeechName.Size = new System.Drawing.Size(117, 20);
            this.txtCurrentSpeechName.TabIndex = 8;
            this.txtCurrentSpeechName.TextChanged += new System.EventHandler(this.txtCurrentSpeechName_TextChanged);
            // 
            // btnSpeechNameConfirm
            // 
            this.btnSpeechNameConfirm.Location = new System.Drawing.Point(249, 283);
            this.btnSpeechNameConfirm.Name = "btnSpeechNameConfirm";
            this.btnSpeechNameConfirm.Size = new System.Drawing.Size(78, 22);
            this.btnSpeechNameConfirm.TabIndex = 9;
            this.btnSpeechNameConfirm.Text = "Zapisz";
            this.btnSpeechNameConfirm.UseVisualStyleBackColor = true;
            this.btnSpeechNameConfirm.Click += new System.EventHandler(this.btnSpeechNameConfirm_Click);
            // 
            // ScenarioEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 382);
            this.Controls.Add(this.btnSpeechNameConfirm);
            this.Controls.Add(this.txtCurrentSpeechName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScenarioTitleInput);
            this.Controls.Add(this.lblScenarioTitle);
            this.Controls.Add(this.lblSpeechText);
            this.Controls.Add(this.listBoxSpeechList);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Name = "ScenarioEditForm";
            this.Text = "ScenarioEditForm";
            this.Deactivate += new System.EventHandler(this.ScenarioEditForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.ListBox listBoxSpeechList;
        private System.Windows.Forms.TextBox lblSpeechText;
        private System.Windows.Forms.Label lblScenarioTitle;
        private System.Windows.Forms.TextBox txtScenarioTitleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentSpeechName;
        private System.Windows.Forms.Button btnSpeechNameConfirm;
    }
}