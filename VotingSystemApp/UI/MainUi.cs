using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemApp.UI
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void candidateEntryButton_Click(object sender, EventArgs e)
        {
            CandidateEntryUi aCandidateEntryUi=new CandidateEntryUi();
            aCandidateEntryUi.ShowDialog();
        }

        private void noOfWinnerButton_Click(object sender, EventArgs e)
        {
            NoOfWinnerEntryUi aNoOfWinnerEntryUi=new NoOfWinnerEntryUi();
            aNoOfWinnerEntryUi.ShowDialog();
        }

        private void voteCastButton_Click(object sender, EventArgs e)
        {
            VoteCastUi aVoteCastUi=new VoteCastUi();
            aVoteCastUi.ShowDialog();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            ResutUi aResutUi=new ResutUi();
            aResutUi.ShowDialog();
        }
    }
}
