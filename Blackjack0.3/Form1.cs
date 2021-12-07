using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack0._3
{
    public partial class Form1 : Form
    {
        //Global variables
        int playerTotalScore;
        int dealerTotalScore;
        int maxScore;
        public Form1()
        {
            InitializeComponent();
        }
        //First deal to each player. Between 1 and 11
        static int Deal()
        {
            int genRand;
            Random r = new Random(Guid.NewGuid().GetHashCode()); //had to add 'Guid.NewGuid().GetHashCode())' as random function uses system clock and it was called to close to the last one giving same number.
            genRand = r.Next(1, 11);
            return genRand;
        }
        static int Hit() //returns number between 1 and 10 so dealer cant go over 21
        {
            int genRand;
            Random r = new Random(Guid.NewGuid().GetHashCode());
            genRand = r.Next(1, 10);
            return genRand;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            int playerDeal;
            int dealerDeal;

            //get first card value from deal function
            playerDeal = Deal();
            dealerDeal = Deal();

            //updates global scores
            playerTotalScore = playerDeal;
            dealerTotalScore = dealerDeal;


            //outputs global variable scores
            labelUserScore.Text = playerTotalScore.ToString();
            labelDealerScore.Text = dealerTotalScore.ToString();
        }
    }
}
