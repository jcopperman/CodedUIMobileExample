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

namespace MyApp
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {            
            string monthName = new DateTime(datePicker.Date.Month).ToString("MMM");

            var dialog = new Windows.UI.Popups.MessageDialog(textBlock.Text + " is on " 
                + datePicker.Date.Day + "of " + monthName + " at " + timePicker.Time.Hours
                + ":" + timePicker.Time.Minutes, "Lorem Ipsum"
                );

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Yes") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("No") { Id = 1 });

            if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily != "Windows.Mobile")
            {
                // Adding a 3rd command will crash the app when running on Mobile 
                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe later") { Id = 2 });
            }

            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();

            var btn = sender as Button;
            btn.Content = $"Result: {result.Label} ({result.Id})";

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Checkbox is now checked";
        }
    }
}
