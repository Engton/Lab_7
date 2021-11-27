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

namespace Lab_7_1
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
            int length = Int32.Parse(textBox1.Text);

            string[] str_arr = textBox2.Text.Split(' ').ToArray();
            int[] int_arr = Array.ConvertAll(str_arr, Int32.Parse);

            int maxValue = int_arr.Max();
            int minValue = int_arr.Min();
            int sum = int_arr.Sum();
            double average = int_arr.Average();
            string odds = "";

            for (int i = 0; i <= int_arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    odds = $"{odds} " + i;
                }
            }

            string text = "";
            foreach(int i in int_arr)
            {
                string temp = i.ToString();
                text = $"{text} " + temp;
            }
            text = $"{text}, максимальное значение: {maxValue}";
            text = $"{text}, минимальное значение: {minValue}";
            text = $"{text}, сумма всех значение: {sum}";
            text = $"{text}, среднее арифметическое: {average}";
            text = $"{text}, непарные числа: {odds}";

            if (text != "")
            {
                MessageBox.Show(text);
            }
        } 
    }
}
