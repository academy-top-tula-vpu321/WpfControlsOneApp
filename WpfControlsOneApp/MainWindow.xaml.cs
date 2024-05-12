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

namespace WpfControlsOneApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();

            //btn.Width = 200;
            //btn.Height = 100;
            //btn.Background = new SolidColorBrush(Color.FromArgb(150, 150, 0, 200));
            //btn.Foreground = new SolidColorBrush(Colors.White);
            //btn.Click += btn_Click;
            //btn.Content = "New Content";
            tablo.Text = count.ToString();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void btnInc_Click(object sender, RoutedEventArgs e)
        {
            ++count;
            tablo.Text = count.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton rbtn)
                MessageBox.Show(rbtn.Content.ToString());
        }
    }
}