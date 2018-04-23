using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Editors;

namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MyButtonInfo bi = comboBoxEdit1.Buttons[0] as MyButtonInfo;
            if (bi.ButtonInfoVisibility == System.Windows.Visibility.Visible)
            {
                bi.ButtonInfoVisibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                bi.ButtonInfoVisibility = System.Windows.Visibility.Visible;
            }
        }
    }

 
    public class MyButtonInfo : ButtonInfo
    {
        public Visibility ButtonInfoVisibility
        {
            get { return (Visibility)GetValue(ButtonInfoVisibilityProperty); }
            set { SetValue(ButtonInfoVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonInfoVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonInfoVisibilityProperty =
            DependencyProperty.Register("ButtonInfoVisibility", typeof(Visibility), typeof(MyButtonInfo), new UIPropertyMetadata(Visibility.Visible));

        
    }
}
