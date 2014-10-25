namespace VotingSystemApp.UI
{
    partial class MainUi
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
            this.resultButton = new System.Windows.Forms.Button();
            this.voteCastButton = new System.Windows.Forms.Button();
            this.noOfWinnerButton = new System.Windows.Forms.Button();
            this.candidateEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(26, 182);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(233, 49);
            this.resultButton.TabIndex = 3;
            this.resultButton.Text = "Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // voteCastButton
            // 
            this.voteCastButton.Location = new System.Drawing.Point(26, 127);
            this.voteCastButton.Name = "voteCastButton";
            this.voteCastButton.Size = new System.Drawing.Size(233, 49);
            this.voteCastButton.TabIndex = 2;
            this.voteCastButton.Text = "Vote Cast";
            this.voteCastButton.UseVisualStyleBackColor = true;
            this.voteCastButton.Click += new System.EventHandler(this.voteCastButton_Click);
            // 
            // noOfWinnerButton
            // 
            this.noOfWinnerButton.Location = new System.Drawing.Point(26, 77);
            this.noOfWinnerButton.Name = "noOfWinnerButton";
            this.noOfWinnerButton.Size = new System.Drawing.Size(233, 44);
            this.noOfWinnerButton.TabIndex = 1;
            this.noOfWinnerButton.Text = "No Of Winners";
            this.noOfWinnerButton.UseVisualStyleBackColor = true;
            this.noOfWinnerButton.Click += new System.EventHandler(this.noOfWinnerButton_Click);
            // 
            // candidateEntryButton
            // 
            this.candidateEntryButton.Location = new System.Drawing.Point(26, 29);
            this.candidateEntryButton.Name = "candidateEntryButton";
            this.candidateEntryButton.Size = new System.Drawing.Size(233, 42);
            this.candidateEntryButton.TabIndex = 0;
            this.candidateEntryButton.Text = "Candidate Entry";
            this.candidateEntryButton.UseVisualStyleBackColor = true;
            this.candidateEntryButton.Click += new System.EventHandler(this.candidateEntryButton_Click);
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.voteCastButton);
            this.Controls.Add(this.noOfWinnerButton);
            this.Controls.Add(this.candidateEntryButton);
            this.Name = "MainUi";
            this.Text = "MainUi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button voteCastButton;
        private System.Windows.Forms.Button noOfWinnerButton;
        private System.Windows.Forms.Button candidateEntryButton;
    }
}