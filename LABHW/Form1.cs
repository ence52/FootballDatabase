using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
            // TODO: This line of code loads data into the 'dataSet1.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
            // TODO: This line of code loads data into the 'dataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.dataSet1.Player);
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }

        private void teamInsertBtn_Click(object sender, EventArgs e)
        {
            teamTableAdapter.Insert(teamNameTxt.Text, teamColorTxt.Text);
            teamTableAdapter.Fill(dataSet1.Team);
        }

        private void teamDeleteBtn_Click(object sender, EventArgs e)
        {
            int TeamID;
            int.TryParse(teamCbx.SelectedValue.ToString(), out TeamID);
            teamTableAdapter.DeleteTeam(TeamID);
            teamTableAdapter.Fill(dataSet1.Team);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerTableAdapter.Insert(playerFNameTxt.Text, PlayerLNameTxt.Text, Convert.ToInt32(playerAgeTxt.Text), Convert.ToInt32(playerTeamCbx.SelectedValue));
            playerTableAdapter.Fill(dataSet1.Player);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PlayerID;
            int.TryParse(playerCbx.SelectedValue.ToString(), out PlayerID);
            playerTableAdapter.DeletePlayer(PlayerID);
            playerTableAdapter.Fill(dataSet1.Player);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coachTableAdapter.Insert(coachFNameTxt.Text,coachLNameTxt.Text,Convert.ToInt32(coachPhoneTxt.Text), Convert.ToInt32(coachTeamCbx.SelectedValue));
            coachTableAdapter.Fill(dataSet1.Coach);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CoachID;
            int.TryParse(coachCbx.SelectedValue.ToString(), out CoachID);
            coachTableAdapter.DeleteCoach(CoachID);
            coachTableAdapter.Fill(dataSet1.Coach);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parentTableAdapter.Insert(parentFNameTxt.Text,parentLNameTxt.Text, Convert.ToInt32(parentPhoneTxt.Text),parentAdressTxt.Text);
            parentTableAdapter.Fill(dataSet1.Parent);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ParentID;
            int.TryParse(parentCbx.SelectedValue.ToString(), out ParentID);
            parentTableAdapter.DeleteParent(ParentID);
            parentTableAdapter.Fill(dataSet1.Parent);
        }
    }
}
