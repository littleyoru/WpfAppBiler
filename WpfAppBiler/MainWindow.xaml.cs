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
using WpfAppBiler.ServiceReference1;

namespace WpfAppBiler
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Service1Client sc = new Service1Client();
            Motor m = new Motor();
            int hk = Convert.ToInt32(textBox.Text);
            m.HK = hk;
            Bil b = new Bil();
            string navn = textBox1.Text;
            b.bilNavn = navn;
            b.antalDoors = 3;
            b.motor = m;
            sc.addBil(b);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Service1Client sc = new Service1Client();
            listBox.Items.Clear();
            Bil[] listen = sc.getAlleBils();
            foreach(var item in listen)
            {
                listBox.Items.Add(item.bilNavn + " " + item.motor.HK + " " + item.antalDoors );
            }
        }
    }
}
