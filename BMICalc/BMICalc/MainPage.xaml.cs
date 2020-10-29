using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMICalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

        void Submit(object sender, System.EventArgs e)
        {
            var weigh = double.Parse(weight.Text);

            var inches = double.Parse(height.Text);
            inches = (inches * 6) + double.Parse(height2.Text);


            var bmi = (weigh / inches / inches) * 703;

            output.Text = $"Your BMI is {bmi}!";

            output.FontSize = 20;
        }
        

    }
}
