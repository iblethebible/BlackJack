using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Blackjack0._3
{
    public partial class Form1 : Form
    {
        //Global variables
        int playerTotalScore;
        int dealerTotalScore;
        int maxScore;

        //Global array of players card history
        int[] playerCardHistory = new int[5];
        //global array of dealer history
        int[] dealerCardHistory = new int[5];
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
            int playerDeal2;
            int dealerDeal;
            

            //get first card value from deal function
            playerDeal = Deal();
            dealerDeal = Deal();

            
            //get second player card
            playerDeal2 = Deal();

            //add player cards to array
            playerCardHistory[0] = playerDeal;
            playerCardHistory[1] = playerDeal2;

            //add dealer card to array
            dealerCardHistory[0] = dealerDeal;

            //updates global scores
            playerTotalScore = playerDeal + playerDeal2;
            dealerTotalScore = dealerDeal;


            //outputs global variable scores
            labelUserScore.Text = playerTotalScore.ToString();
            labelDealerScore.Text = dealerTotalScore.ToString();


            //loop twice displaying first 2 card scores in array into list
            int i = 0;
            for (i = 0;i<2;i++)
            {
                listBoxPlayerHistory.Items.Insert(i, playerCardHistory[i]);
            }

            listBoxDealerHistory.Items.Insert(0, dealerCardHistory[0]);

            buttonDeal.Visible = false;
            buttonHit.Visible = true;
            buttonStick.Visible = true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            buttonDeal.Visible = true;
            buttonHit.Visible = false;
            buttonStick.Visible = false;

            listBoxPlayerHistory.Items.Clear();

            playerTotalScore = 0;
            dealerTotalScore = 0;

            labelUserScore.Text = playerTotalScore.ToString();
            labelDealerScore.Text = dealerTotalScore.ToString();
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            int playerHit;

            playerHit = Hit();
            //add to array------How do i add to the next element?
            playerCardHistory[2] = playerHit;   


            //update global player score with hit card
            playerTotalScore += playerHit;

            labelUserScore.Text = playerTotalScore.ToString();


           //adds each subsequent hit to new line on list
           listBoxPlayerHistory.Items.Add(playerHit);


            




        }
    }
}
