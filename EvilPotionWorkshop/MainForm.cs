namespace EvilPotionWorkshop
{
    public partial class MainForm : Form
    {
        private int _vampireFinger = 12;
        private int _giantSkull = 8;

        private const int TotalBrewSeconds = 5;
        private int _currentProgress;

        public MainForm()
        {
            InitializeComponent();

            Recipe.Items.Add("Blood‑Red Finger Sacrifice");
            Recipe.Items.Add("Giant's Resentment");
            Recipe.SelectedIndex = 0;

            timer1.Stop();
            progressBar1.Maximum = TotalBrewSeconds; 
            progressBar1.Value = 0;

            RefreshIngredientDisplay();
            Result.Text = "Ready for brewing.";
        }

        void RefreshIngredientDisplay()
        {
            string select = Recipe.SelectedItem.ToString();
            if (select == "Blood‑Red Finger Sacrifice")
            {
                IngredientInfo.Text = $"Need：Vampire Finger ×2\nStock：{_vampireFinger}";
            }
            else
            {
                IngredientInfo.Text = $"Need：Giant Skull ×3\nStock：{_giantSkull}";
            }
        }

        void BrewFinish()
        {
            string recipe = Recipe.SelectedItem.ToString();

            if (recipe == "Blood‑Red Finger Sacrifice")
            {
                _vampireFinger -= 2;
            }
            else
            {
                _giantSkull -= 3;
            }

            RefreshIngredientDisplay();
            Result.Text = "Production complete. The demon is whispering...\nReady for the next round of production.";
        }

        private void Recipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIngredientDisplay();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return; 

            string recipe = Recipe.SelectedItem.ToString();

            if (recipe == "Blood‑Red Finger Sacrifice" && _vampireFinger < 2)
            {
                MessageBox.Show("Vampire Finger stock insufficient!");
                return;
            }
            if (recipe == "Giant's Resentment" && _giantSkull < 3)
            {
                MessageBox.Show("Giant Skull stock insufficient!");
                return;
            }

            _currentProgress = 0;
            progressBar1.Value = 0;
            Result.Text = "Brewing…";

            timer1.Start();
            Start.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _currentProgress++;
            progressBar1.Value = _currentProgress;

            if (_currentProgress >= TotalBrewSeconds)
            {
                timer1.Stop();
                BrewFinish();
                Start.Enabled = true; 
            }
        }
    }
}
