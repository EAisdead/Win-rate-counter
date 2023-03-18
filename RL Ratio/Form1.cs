namespace RL_Ratio
{
    public partial class Form1 : Form
    {

        double wins;
        int losses;
        double rate;

        public void WinsUp()
        { 
            wins++;
            lblWins.Text = wins.ToString();
        }

        public void WinsDown()
        {
            if (wins > 0) 
            { 
            wins--;
            lblWins.Text = wins.ToString();
            }
        }

        public void LossesUp()
        {
            losses++;
            lblLosses.Text = losses.ToString();
        }

        public void LossesDown()
        {
            if (losses > 0)
            {
                losses--;
                lblLosses.Text = losses.ToString();
            }
            
        }

        public void WinRate()
        {
            rate = (wins / (wins + losses)) * 100;
            lblWinRate.Text = Math.Round(rate).ToString() + "%";
            if (wins == 0 && losses == 0)
            {
                rate = 0;
                lblWinRate.Text = rate.ToString() + "%";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            LossesUp();
            WinRate();
            if (losses >= 1)
            {
                btnDecreaseL.Enabled = true;
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            WinsUp();
            WinRate();
            if (wins >= 1)
            {
                btnDecreaseW.Enabled = true;
            }
        }

        private void lblWins_Click(object sender, EventArgs e)
        {
            
        }

        private void lblWinRate_Click(object sender, EventArgs e)
        {

        }

        private void btnDecreaseW_Click(object sender, EventArgs e)
        {
            WinsDown();
            WinRate();
            if (wins == 0)
            {
                btnDecreaseW.Enabled = false;
            }
        }

        private void btnDecreaseL_Click(object sender, EventArgs e)
        {
            LossesDown();
            WinRate();
            if (losses == 0)
            {
                btnDecreaseL.Enabled = false;
            }
        }
        

        private void lblLosses_Click(object sender, EventArgs e)
        {

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        public void ResetAll()
        {
            wins = 0;
            lblWins.Text = wins.ToString();
            losses = 0;
            lblLosses.Text = losses.ToString();
            rate = 0;
            lblWinRate.Text = rate.ToString() + "%";
            btnDecreaseW.Enabled = false;
            btnDecreaseL.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}