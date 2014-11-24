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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace ImagineCup
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Stop_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "Stop";
        }

        private void Play_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "Play";
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "heheheh";
        }

        private void Reset_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "reset";
        }

        private void gangqin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "乐器：钢琴";
        }

        private void jita_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "乐器：吉他";
        }

        private void liuxing_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "风格：流行";
        }

        private void minyao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "风格：民谣";
        }

        private void modeA_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：A";
        }
        private void modeB_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：B";
        }
        private void modeC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：C";
        }
        private void modeD_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：D";
        }
        private void modeE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：E";
        }
        private void modeF_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：F";
        }
        private void modeG_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Text = "调式：G";
        }
    }
}
