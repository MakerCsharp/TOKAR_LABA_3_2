using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static MyControls.MyControl1;

namespace WpfHost
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private System.Windows.Application app;
        private Window myWindow;
        private FontWeight initFontWeight;
        private Double initFontSize;
        private FontStyle initFontStyle;
        private SolidColorBrush initBackBrush;
        private SolidColorBrush initForeBrush;
        private FontFamily initFontFamily;
        private bool UIIsReady = false;
        private void Init(object sender, RoutedEventArgs e)
        {
            app = System.Windows.Application.Current;
            myWindow = (Window)app.MainWindow;
            myWindow.SizeToContent = SizeToContent.WidthAndHeight;
            wfh.TabIndex = 10;
            initFontSize = wfh.FontSize;
            initFontWeight = wfh.FontWeight;
            initFontFamily = wfh.FontFamily;
            initFontStyle = wfh.FontStyle;
            initBackBrush = (SolidColorBrush)wfh.Background;
            initForeBrush = (SolidColorBrush)wfh.Foreground;
            MyControl1 mc = (MyControl1)wfh.Child;
            mc.OnButtonClick += Pane1_OnButtonClick;
            UIIsReady = true;
        }

        private void Pane1_OnButtonClick(object sender, MyControlEventArgs args)
        {
            txtName.Inlines.Clear();
            txtAddress.Inlines.Clear();
            txtCity.Inlines.Clear();
            txtState.Inlines.Clear();
            txtZip.Inlines.Clear();
            if (args.IsOK)
            {
                txtName.Inlines.Add(" " + args.MyName);
                txtAddress.Inlines.Add(" " + args.MyStreetAddress);
                txtCity.Inlines.Add(" " + args.MyCity);
                txtState.Inlines.Add(" " + args.MyState);
                txtZip.Inlines.Add(" " + args.MyZip);
            }
        }


        private void BackColorChanged(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rdbtnBackGreen))
            {
                wfh.Background = new SolidColorBrush(Colors.LightGreen);
            }
            else if (sender.Equals(rdbtnBackSalmon))
            {
                wfh.Background = new SolidColorBrush(Colors.LightSalmon);
            }
            else if (UIIsReady == true)
            {
                wfh.Background = initBackBrush;
            }
        }
        private void ForeColorChanged(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rdbtnForeRed))
            {
                wfh.Foreground = new SolidColorBrush(Colors.Red);
            }
            else if (sender.Equals(rdbtnForeYellow))
            {
                wfh.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else if (UIIsReady == true)
            {
                wfh.Foreground = initForeBrush;
            }
        }
        private void FontChanged(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rdbtnTimes))
            {
                wfh.FontFamily = new FontFamily("Times New Roman");
            }
            else if (sender.Equals(rdbtnWingdings))
            {
                wfh.FontFamily = new FontFamily("Wingdings");
            }
            else if (UIIsReady == true)
            {
                wfh.FontFamily = initFontFamily;
            }
        }
        private void FontSizeChanged(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rdbtnTen))
            {
                wfh.FontSize = 10;
            }
            else if (sender.Equals(rdbtnTwelve))
            {
                wfh.FontSize = 12;
            }
            else if (UIIsReady == true)
            {
                wfh.FontSize = initFontSize;
            }
        }
        private void StyleChanged(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rdbtnItalic))
            {
                wfh.FontStyle = FontStyles.Italic;
            }
            else if (UIIsReady == true)
            {
                wfh.FontStyle = initFontStyle;
            }
        }
        private void WeightChanged(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(rdbtnBold))
            {
                wfh.FontWeight = FontWeights.Bold;
            }
            else if (UIIsReady == true)
            {
                wfh.FontWeight = initFontWeight;
            }
        }
    }
}
