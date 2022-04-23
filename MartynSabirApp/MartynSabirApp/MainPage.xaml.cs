using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MartynSabirApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var first = float.Parse(firstTextBox.Text);

                var second = float.Parse(secondTextBox.Text);

                var operation = (sender as Button).Text;

                switch (operation)
                {
                    case "Умножить":
                        resultLabel.Text = (first * second).ToString();
                        break;
                    case "Плюс":
                        resultLabel.Text = (first + second).ToString();
                        break;
                    case "Минус":
                        resultLabel.Text = (first - second).ToString();
                        break;
                    case "Делить":
                        resultLabel.Text = (first / second).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                resultLabel.Text = "Ошибка";
            }
        }
    }
}
