using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
        }
        private async void AnimateBackground()
        {
            Action<double> forward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;

            while (true)
            {
                bdGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
        public async void onburger(object sender, EventArgs e)
        {
            int v1 = 180;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onpizza(object sender, EventArgs e)
        {
            int v1 = 240;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onfries(object sender, EventArgs e)
        {
            int v1 = 80;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onhotdog(object sender, EventArgs e)
        {
            int v1 = 280;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onpopcorn(object sender, EventArgs e)
        {
            int v1 = 50;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onsandwich(object sender, EventArgs e)
        {
            int v1 = 70;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onnoodle(object sender, EventArgs e)
        {
            int v1 = 90;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
        public async void onicecream(object sender, EventArgs e)
        {
            int v1 = 40;
            int q1 = int.Parse(txtq.Text);
            await Navigation.PushAsync(new Page6(v1, q1));
        }
    }
}