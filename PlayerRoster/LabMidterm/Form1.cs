using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMidterm
{
    public partial class Form1 : Form
    {
        private int index;
        private const int numPlayers = 5;
        private BasketballPlayer[] bp = new BasketballPlayer[numPlayers];
        public Form1()
        {

            //create and initialize players
            BasketballPlayer p1 = new BasketballPlayer("LeBron James", "Forward", 6, 8);
            BasketballPlayer p2 = new BasketballPlayer("Paul George", "Center", 6, 9);
            BasketballPlayer p3 = new BasketballPlayer("Carmelo Anthony", "Forward", 6, 8);
            BasketballPlayer p4 = new BasketballPlayer("Dwyane Wade", "Guard", 6, 4);
            BasketballPlayer p5 = new BasketballPlayer("Kyrie Irving", "Guard", 6, 3);

            //create and initialize array
            bp[0] = p1;
            bp[1] = p2;
            bp[2] = p3;
            bp[3] = p4;
            bp[4] = p5;

            InitializeComponent();

            //initialize form
            index = 0;
            showPlayer(index);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bp[index].Name = txtName.Text;
            bp[index].HeightFt=Convert.ToInt32(numFt.Value);
            bp[index].HeightIn=Convert.ToInt32(numIn.Value);
            //determine which radio button is active and derive position from that
            if(rbGuard.Checked)
            {
                bp[index].Position = "Guard";
            }
            else if (rbCenter.Checked)
            {
                bp[index].Position = "Center";
            }
            else if (rbForward.Checked)
            {
                bp[index].Position = "Forward";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            showPlayer(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            showPlayer(index);
        }

        //method to update player informaion displayed with new index
        //consolidate work to one method
        private void showPlayer(int index)
        {
            lblPlayer.Text = "Player " + (index + 1);
            txtName.Text = bp[index].Name;
            rbFinder(bp[index].Position);
            numFt.Value = bp[index].HeightFt;
            numIn.Value = bp[index].HeightIn;

            //disable next/previous buttons
            //performing each time player is updated prevents validation check with Click methods
            if(index==0)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
            }
            else if(index==4)
            {
                btnNext.Enabled = false;
                btnPrevious.Enabled = true;
            }
            else
            {
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
        }
        //method to determine which Radio button to check and ncheck rest
        private void rbFinder(String position)
        {
            if(position == "Center")
            {
                rbCenter.Checked = true;
                rbForward.Checked = false;
                rbGuard.Checked = false;
            }
            else if (position == "Forward")
            {
                rbForward.Checked = true;
                rbCenter.Checked = false;
                rbGuard.Checked = false;
            }
            else if (position == "Guard")
            {
                rbGuard.Checked = true;
                rbCenter.Checked = false;
                rbForward.Checked = false;
            }
        }
    }
}
