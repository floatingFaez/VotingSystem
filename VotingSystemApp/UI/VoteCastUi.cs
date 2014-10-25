using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApp.BLL;
using VotingSystemApp.DLL.DAO;

namespace VotingSystemApp.UI
{
    public partial class VoteCastUi : Form
    {
        private CandidateBll aCandidateBll;
        public VoteCastUi()
        {
            aCandidateBll = new CandidateBll();
            InitializeComponent();
            GetAllSymbolInComboBox();
        }

        private void GetAllSymbolInComboBox()
        {
            Candidate aCandidate = new Candidate();
            List<Candidate> candidates = aCandidateBll.GetAllCandidate(aCandidate);
        }

        private void castButton_Click(object sender, EventArgs e)
        {

        }
    }
}
