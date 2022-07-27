namespace Activity_8
{
    partial class calorieCalcForm
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
            this.fatCounter = new System.Windows.Forms.NumericUpDown();
            this.carbCounter = new System.Windows.Forms.NumericUpDown();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fatCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // fatCounter
            // 
            this.fatCounter.Location = new System.Drawing.Point(240, 22);
            this.fatCounter.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.fatCounter.Name = "fatCounter";
            this.fatCounter.Size = new System.Drawing.Size(120, 23);
            this.fatCounter.TabIndex = 0;
            this.fatCounter.ThousandsSeparator = true;
            // 
            // carbCounter
            // 
            this.carbCounter.Location = new System.Drawing.Point(240, 67);
            this.carbCounter.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.carbCounter.Name = "carbCounter";
            this.carbCounter.Size = new System.Drawing.Size(120, 23);
            this.carbCounter.TabIndex = 1;
            // 
            // fatLabel
            // 
            this.fatLabel.Location = new System.Drawing.Point(50, 10);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(184, 43);
            this.fatLabel.TabIndex = 2;
            this.fatLabel.Text = "Please input how many grams \r\nof fat you intake daily";
            this.fatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carbLabel
            // 
            this.carbLabel.Location = new System.Drawing.Point(50, 55);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(184, 43);
            this.carbLabel.TabIndex = 3;
            this.carbLabel.Text = "Please input how many grams \r\nof carbs you intake daily";
            this.carbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Location = new System.Drawing.Point(19, 169);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(215, 15);
            this.calorieLabel.TabIndex = 4;
            this.calorieLabel.Text = "Daily Caloric Intake from Fat and Carbs:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(240, 108);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(120, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answerLabel.Location = new System.Drawing.Point(240, 163);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 26);
            this.answerLabel.TabIndex = 6;
            // 
            // calorieCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 210);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.calorieLabel);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbCounter);
            this.Controls.Add(this.fatCounter);
            this.Name = "calorieCalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.fatCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown fatCounter;
        private NumericUpDown carbCounter;
        private Label fatLabel;
        private Label carbLabel;
        private Label calorieLabel;
        private Button submitButton;
        private Label answerLabel;
    }
}