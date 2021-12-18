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

namespace Lab4WPF
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


        public string Result(string rate, string sum)
        {
            string result = "Введено недопустимое значение";
            try
            {
                result = Convert.ToString(Convert.ToDouble(rate) * Convert.ToDouble(sum));
                return result;
            }
            catch
            {
                return result;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resSumDol.Text = Result(rateDol.Text, sumDol.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resSumEuro.Text = Result(rateEuro.Text, sumEuro.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resSumGriv.Text = Result(rateGriv.Text, sumGriv.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resSumDram.Text = Result(rateDram.Text, sumDram.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            resSumInch.Text = Result("0,0254", sumInch.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            resSumFut.Text = Result("0,3048", sumFut.Text);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            resSumMil.Text = Result("1609,344", sumMil.Text);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            resSumVer.Text = Result("1066,8", sumVer.Text);
        }
    }
}
