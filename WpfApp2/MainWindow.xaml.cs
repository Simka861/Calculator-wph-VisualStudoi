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

namespace WpfApp2
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text == "00")
            {
                textBox1.Text = B.Content.ToString();
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "0,";
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Content.ToString();
            }
        }

        private void Button_Comma(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += B.Content.ToString();
            }
            if (Convert.ToChar(textBox1.Text[0]) == Convert.ToChar(","))
            {
                textBox1.Text = "0,";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "00";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "00";
            textBox2.Text = "";
        }
        double Num1, Num2, Num3;

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            Num1 = Convert.ToDouble(textBox1.Text);
          
            znak = Convert.ToChar(B.Content.ToString()[0]);
            textBox2.Text = Num1 + " " + znak;
            textBox1.Text = "00";
        }

        char znak = '+';
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void button20_Clickbutton20_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(textBox1.Text);
            if (znak == '+')
            {
                Num3 = Num1 + Num2;
            }
            else if (znak == '-')
            {
                Num3 = Num1 - Num2;
            }
            else if (znak == '/')
            {
                Num3 = Num1 / Num2;
            }
            else if (znak == '*')
            {
                Num3 = Num1 * Num2;
            }


            textBox2.Text += " " + Num2 + " = " + Num3;
            textBox1.Text = Convert.ToString(Num3);
        }

    }
}
