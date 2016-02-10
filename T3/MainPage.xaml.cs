using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void countButton_Click(object sender, RoutedEventArgs e)
        {
            int width = int.Parse(lText.Text);
            int height = int.Parse(hText.Text);
            int fwidth = int.Parse(wText.Text);
            int garea = (width * height) - (fwidth * height);
            int area = width * height;
            waText.Text = area.ToString();
            gaText.Text = garea.ToString();
            int circle = (2 * width) + (2 * height);
            ciText.Text = circle.ToString();
        }
    }
}
