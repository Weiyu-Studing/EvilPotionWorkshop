namespace EvilPotionWorkshop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Recipe = new ComboBox();
            IngredientInfo = new Label();
            Start = new Button();
            Result = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            HorrorTip = new Label();
            SuspendLayout();
            // 
            // Recipe
            // 
            Recipe.FormattingEnabled = true;
            Recipe.Location = new Point(96, 118);
            Recipe.Name = "Recipe";
            Recipe.Size = new Size(160, 25);
            Recipe.TabIndex = 0;
            Recipe.SelectedIndexChanged += Recipe_SelectedIndexChanged;
            // 
            // IngredientInfo
            // 
            IngredientInfo.AutoSize = true;
            IngredientInfo.BackColor = SystemColors.ActiveCaptionText;
            IngredientInfo.ForeColor = SystemColors.ButtonHighlight;
            IngredientInfo.Location = new Point(96, 173);
            IngredientInfo.Name = "IngredientInfo";
            IngredientInfo.Size = new Size(43, 17);
            IngredientInfo.TabIndex = 1;
            IngredientInfo.Text = "label1";
            // 
            // Start
            // 
            Start.Location = new Point(96, 232);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 3;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = SystemColors.ActiveCaptionText;
            Result.ForeColor = Color.Lime;
            Result.Location = new Point(388, 235);
            Result.Name = "Result";
            Result.Size = new Size(43, 17);
            Result.TabIndex = 4;
            Result.Text = "label2";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(330, 375);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(160, 23);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // HorrorTip
            // 
            HorrorTip.BackColor = Color.Black;
            HorrorTip.Font = new Font("Algerian", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            HorrorTip.ForeColor = Color.DarkRed;
            HorrorTip.Location = new Point(361, 0);
            HorrorTip.Name = "HorrorTip";
            HorrorTip.Size = new Size(439, 66);
            HorrorTip.TabIndex = 6;
            HorrorTip.Text = "Legend has it that if you feed the demon until it’s full,                                                          you will gain immense power...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(HorrorTip);
            Controls.Add(progressBar1);
            Controls.Add(Result);
            Controls.Add(Start);
            Controls.Add(IngredientInfo);
            Controls.Add(Recipe);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Recipe;
        private Label IngredientInfo;
        private Button Start;
        private Label Result;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label HorrorTip;
    }
}
