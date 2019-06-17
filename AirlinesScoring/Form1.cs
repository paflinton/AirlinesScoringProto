using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinesScoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnP1Add_Click(object sender, EventArgs e)
        {
            AddScore(txtP1Score, txtP1Points);
        }

        /* add points to a provided text box that scores score.
         * Note that this WILL fail if provided a text box
         * that does not exclusively score integers */
        private void AddScore(TextBox scoreBox, TextBox pointBox)
        {
            int score;
            int points;
            //make sure the user input an interger for points
            if (IsValidInput(pointBox.Text))
            {
                //extract the score and points from the textboxes
                score = Int32.Parse(scoreBox.Text);
                points = Int32.Parse(pointBox.Text);
                score += points;
                //save the new score in the score textbox
                scoreBox.Text = score.ToString();
                //reset the points textbox
                pointBox.Text = "";
            }
        }

        private Boolean IsValidInput(string input)
        {
            int number = 0;
            if (Int32.TryParse(input, out number)) return true;
            else
            {
                MessageBox.Show("'Points' must be a valid integer.", "Invalid Input");
                return false;
            }
        }

        private void btnP1Reset_Click(object sender, EventArgs e)
        {
            ResetScore(txtP1Score);
        }

        //reset the score of a provided text box.
        private void ResetScore(TextBox textIn)
        {
            textIn.Text = "0";
        }

        private void btnP2Add_Click(object sender, EventArgs e)
        {
            AddScore(txtP2Score, txtP2Points);
        }

        private void btnP2Reset_Click(object sender, EventArgs e)
        {
            ResetScore(txtP2Score);
        }

        private void btnP3Add_Click(object sender, EventArgs e)
        {
            AddScore(txtP3Score, txtP3Points);
        }

        private void btnP3Reset_Click(object sender, EventArgs e)
        {
            ResetScore(txtP3Score);
        }

        private void btnP4Add_Click(object sender, EventArgs e)
        {
            AddScore(txtP4Score, txtP4Points);
        }

        private void btnP4Reset_Click(object sender, EventArgs e)
        {
            ResetScore(txtP4Score);
        }

        private void btnP5Add_Click(object sender, EventArgs e)
        {
            AddScore(txtP5Score, txtP5Points);
        }

        private void btnP5Reset_Click(object sender, EventArgs e)
        {
            ResetScore(txtP5Score);
        }

        private void btnP6Add_Click(object sender, EventArgs e)
        {
            AddScore(txtP6Score, txtP6Points);
        }

        private void btnP6Reset_Click(object sender, EventArgs e)
        {
            ResetScore(txtP6Score);
        }
    }
}
