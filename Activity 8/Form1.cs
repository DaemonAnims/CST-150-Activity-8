namespace Activity_8
{
    public partial class calorieCalcForm : Form
    {
        public calorieCalcForm()
        {
            InitializeComponent();
        }
        //Method for calculating calories from fat grams
        private int FatCalories(int fatGrams)
        {
            //multiplies grams of fat by 9 to get correct calories
            return fatGrams * 9;
        }
        //Method for calculating calories from carb grams
        private int CarbCalories(int carbGrams)
        {
            //multiplies grams of carbs by 4 to get correct calories
            return carbGrams * 4;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //get both grams of fat and carbs
            int fatGrams = (int)fatCounter.Value;
            int carbGrams = (int)carbCounter.Value;
            //add calories from both FatCalories and CarbCalories methods to get total calories 
            int calories = FatCalories(fatGrams) + CarbCalories(carbGrams);
            //display calories
            answerLabel.Text = calories.ToString("n0") + "cal";
        }
    }
}