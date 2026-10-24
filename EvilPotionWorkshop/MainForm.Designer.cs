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
            Recipe = new ComboBox();
            gredientInfo = new Label();
            button1 = new Button();
            Result = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Recipe
            // 
            Recipe.FormattingEnabled = true;
            Recipe.Location = new Point(96, 118);
            Recipe.Name = "Recipe";
            Recipe.Size = new Size(160, 25);
            Recipe.TabIndex = 0;
            // 
            // gredientInfo
            // 
            gredientInfo.AutoSize = true;
            gredientInfo.Location = new Point(96, 173);
            gredientInfo.Name = "gredientInfo";
            gredientInfo.Size = new Size(43, 17);
            gredientInfo.TabIndex = 1;
            gredientInfo.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(96, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            Result.AutoSize = true;
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
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(Result);
            Controls.Add(button1);
            Controls.Add(gredientInfo);
            Controls.Add(Recipe);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Recipe;
        private Label gredientInfo;
        private Button button1;
        private Label Result;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
