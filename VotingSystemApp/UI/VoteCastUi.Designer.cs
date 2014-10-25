namespace VotingSystemApp.UI
{
    partial class VoteCastUi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.voteremailTextBox = new System.Windows.Forms.TextBox();
            this.castButton = new System.Windows.Forms.Button();
            this.voteSymbolComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cast Your Vote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voter Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Symbol Of Candidate ";
            // 
            // voteremailTextBox
            // 
            this.voteremailTextBox.Location = new System.Drawing.Point(170, 49);
            this.voteremailTextBox.Name = "voteremailTextBox";
            this.voteremailTextBox.Size = new System.Drawing.Size(254, 20);
            this.voteremailTextBox.TabIndex = 0;
            // 
            // castButton
            // 
            this.castButton.Location = new System.Drawing.Point(340, 105);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(84, 23);
            this.castButton.TabIndex = 2;
            this.castButton.Text = "Cast";
            this.castButton.UseVisualStyleBackColor = true;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // voteSymbolComboBox
            // 
            this.voteSymbolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voteSymbolComboBox.FormattingEnabled = true;
            this.voteSymbolComboBox.Location = new System.Drawing.Point(170, 77);
            this.voteSymbolComboBox.Name = "voteSymbolComboBox";
            this.voteSymbolComboBox.Size = new System.Drawing.Size(254, 21);
            this.voteSymbolComboBox.TabIndex = 1;
            // 
            // VoteCastUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 150);
            this.Controls.Add(this.voteSymbolComboBox);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.voteremailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoteCastUi";
            this.Text = "VoteCastUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox voteremailTextBox;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.ComboBox voteSymbolComboBox;
    }
}