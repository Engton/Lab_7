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

namespace Lab_7_3
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

        Store store = new Store();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Article article = new Article();
            article.ArticleName = textBox1.Text;
            article.StoreName = textBox2.Text;
            article.Cost = double.Parse(textBox3.Text);
            store.Articles.Add(article);
        }

        private void StackPanel_GotFocus(object sender, RoutedEventArgs e)
        {
            string text = "";
            foreach(Article a in store.Articles)
            {
                text = $"{text} {a.ArticleName} {a.StoreName} {a.Cost}";
            }
            
        }
    }
}
