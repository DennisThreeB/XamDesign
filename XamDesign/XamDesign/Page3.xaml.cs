using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamDesign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        public void OnButtonClickedEnemy(object sender, EventArgs e)
        {
            //Clicks +1, Deal Damage (SPK), start animation, if counter/10 true --> bossenemy, if counter/100 true --> special bossenemy,
        }
    }
}