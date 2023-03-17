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
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            WinsUp();
            WinRate();
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
        }

        private void btnDecreaseL_Click(object sender, EventArgs e)
        {
            LossesDown();
            WinRate();
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
            lblWinRate.Text = rate.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}