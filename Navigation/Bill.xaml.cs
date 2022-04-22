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
    public partial class Page6 : ContentPage
    {
        public Page6(int v1, int q1)
        {
            InitializeComponent();
            int v = v1;
            string price = v.ToString();
            int qty = q1;
            int r = v * qty;
            int gst = (r * 5) / 100;
            int result = r + gst;
            txtqty.Text = qty.ToString();
            txttp.Text = r.ToString();
            txtprice.Text = price;
            txtgst.Text = gst.ToString();
            txtresult.Text = result.ToString();
        }
    }
}