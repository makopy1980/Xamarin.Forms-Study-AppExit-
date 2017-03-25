using System;
using Xamarin.Forms;
using XFExitSample.DependencyServices;

namespace XFExitSample
{
    public partial class XFExitSamplePage : ContentPage
    {
        public XFExitSamplePage()
        {
            InitializeComponent();
        }

        private void OnExitButtonTapped(object sender, EventArgs e)
        {
            DependencyService.Get<IApplicationUtil>().Exit();
        }
    }
}
