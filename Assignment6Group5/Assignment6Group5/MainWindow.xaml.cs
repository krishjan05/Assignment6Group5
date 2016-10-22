
/*File: MainWindow.xaml.cs
 * Created by: Krishna Kanhaiya
 * Create on: 21 October 2016
 * Program to generate prime number from 1 to 100
 */
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

namespace Assignment6Group5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    lstResult.Items.Add(i);
                }
            }
        }
        //boolean function to check if the number is prime
        public bool IsPrime(int num)
        {
            if (num == 1)
                return false;
            if (num == 2)
                return true;
            for(int j=2; j <= Math.Sqrt(num); j++)
            {
                if (num % j == 0)
                    return false;   
            }
            return true;
        }
    }
}
