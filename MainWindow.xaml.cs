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

namespace WpfApp_практическая_работа_1_Гуляева
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid.Background = Brushes.Gray;
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            texbox1.Text = "*****";

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            texbox1.Text = "00000";


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            texbox1.Text = "+++++";
            
        }

       
        }
    }
    
    


