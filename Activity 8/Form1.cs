namespace Activity_8
{
    public partial class calorieCalcForm : Form
    {
        public calorieCalcForm()
        {
            InitializeComponent();
        }

        private int FatCalories(int fatGrams)
        {
            return fatGrams * 9;
        }

        private int CarbCalories(int carbGrams)
        {
            return carbGrams * 4;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int fatGrams = (int)fatCounter.Value;
            int carbGrams = (int)carbCounter.Value;
            int calories = FatCalories(fatGrams) + CarbCalories(carbGrams);
            answerLabel.Text = calories.ToString("n0") + "cal";
        }
    }
}