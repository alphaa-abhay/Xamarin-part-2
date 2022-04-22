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
    public partial class Page2 : CarouselPage
    {
        public Page2()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
        }
        private async void AnimateBackground()
        {
            Action<double> forward = input => bgGradient.AnchorY = input;
            Action<double> backward = input => bgGradient.AnchorY = input;
            Action<double> forward1 = input => bgGradient1.AnchorY = input;
            Action<double> backward1 = input => bgGradient1.AnchorY = input;
            Action<double> forward2 = input => bgGradient1.AnchorY = input;
            Action<double> backward2 = input => bgGradient1.AnchorY = input;

            while (true)
            {
                bgGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bgGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bgGradient1.Animate(name: "forward", callback: forward1, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bgGradient1.Animate(name: "backward", callback: backward1, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bgGradient2.Animate(name: "forward", callback: forward2, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bgGradient2.Animate(name: "backward", callback: backward2, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
        public async void onhome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Xamarin_App.Page1());
        }
    }
}