namespace EvilPotionWorkshop
{
    public partial class MainForm : Form
    {
        private int _unicornHair = 12;
        private int _phoenixFeather = 8;

        
        private const int TotalBrewSeconds = 5;
        
        private int _currentProgress;

        public MainForm()
        {
            InitializeComponent();
            
            Recipe.Items.Add("Healing Potion");
            Recipe.Items.Add("Fire Elixir");
            Recipe.SelectedIndex = 0;

            timer1.Stop();
            progressBar1.Maximum = TotalBrewSeconds; 
            progressBar1.Value = 0;

            RefreshIngredientDisplay(); 
        }

        void RefreshIngredientDisplay()
        {
            string select = Recipe.SelectedItem.ToString();
            if (select == "Healing Potion")
            {
                IngredientInfo.Text = $"Need：UnicornHair ×2\nStock：{_unicornHair}";
            }
            else
            {
                IngredientInfo.Text = $"Need：PhoenixFeather ×3\nStock：{_phoenixFeather}";
            }
            Result.Text = "Production complete. \nReady for the next round of production.";
        }

        void BrewFinish()
        {
            string recipe = Recipe.SelectedItem.ToString();
            if (recipe == "Healing Potion")
            {
                _unicornHair -= 2;
                Result.Text = "Complete：Healing Potion，Restore HP";
            }
            else
            {
                _phoenixFeather -= 3;
                Result.Text = "Complete：Fire Elixir，Fire Damage +50";
            }
            RefreshIngredientDisplay();
        }

        private void Recipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIngredientDisplay();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return; 

            string recipe = Recipe.SelectedItem.ToString();

            if (recipe == "Healing Potion" && _unicornHair < 2)
            {
                MessageBox.Show("UnicornHair stock insufficient!");
                return;
            }
            if (recipe == "Fire Elixir" && _phoenixFeather < 3)
            {
                MessageBox.Show("PhoenixFeather stock insufficient!");
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
