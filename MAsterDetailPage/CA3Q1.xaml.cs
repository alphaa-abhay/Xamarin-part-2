using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_App
{
    public partial class Page1 : MasterDetailPage
    {
        public Page1()
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
        public void onfirst(object sender, EventArgs e)
        {
            Detail = new Page2();
        }
        public void onsecond(object sender, EventArgs e)
        {
            Detail = new Page3();
        }
        public void onthird(object sender, EventArgs e)
        {
            Detail = new Page4();
        }
        public void onhome(object sender, EventArgs e)
        {
            Detail = new Page1();
        }
    }
}