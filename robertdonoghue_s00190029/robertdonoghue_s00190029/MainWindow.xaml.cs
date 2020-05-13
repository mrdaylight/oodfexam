using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace robertdonoghue_s00190029
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Phone> phones = new List<Phone>();
            //create phones
            Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
            Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.png");
            phones.Add(p1);
            phones.Add(p2);

            lbx_phones.ItemsSource = phones;

            
        }

        private void lbx_phones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_blk_price.Text = this.lbx_phones.SelectedItem.ToString();
        }
    }
}
