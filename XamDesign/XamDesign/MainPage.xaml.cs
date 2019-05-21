using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamDesign
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        // Eventhandler for Tabs on TabMenu
        public void NavShop_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page1();
            PlaceHolder.Content = page.Content;
        }
        public void NavHeroes_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page2();
            PlaceHolder.Content = page.Content;
        }
        public void NavThree_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page3();
            PlaceHolder.Content = page.Content;
        }
        public void NavItems_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page4();
            PlaceHolder.Content = page.Content;

        }
        public void NavStats_Tapped(object sender, System.EventArgs e)
        {
            var page = new Page5();
            PlaceHolder.Content = page.Content;
            PlaceHolder.ControlTemplate = page.ControlTemplate;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
