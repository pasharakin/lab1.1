using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double x1 = Convert.ToInt32(zn1.Text);
            double y1 = Convert.ToInt32(zn2.Text);
            double x2 = Convert.ToInt32(zn3.Text);
            double y2 = Convert.ToInt32(zn4.Text);
            double x3 = Convert.ToInt32(zn5.Text);
            double y3 = Convert.ToInt32(zn6.Text);
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            double P = p * 2;
            rezP.Text = P.ToString();
            rezS.Text = S.ToString();
        }
    }
}
