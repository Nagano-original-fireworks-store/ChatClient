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
using static System.Net.Mime.MediaTypeNames;

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            LogPage.Log("");
            InitializeComponent();
            Program.Init();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 获取输入框的文本内容
            string inputText = myTextBox.Text;
            Program.Tests(inputText);
            LogPage.Log($"你输入的内容是: {inputText}");
        }// 按钮点击事件，初始化并显示 LogPage
        private void OnShowLogPageClick(object sender, RoutedEventArgs e)
        {
            // 通过 Instance 属性来初始化 LogPage 实例
            LogPage.Log("LogPage initialized from MainWindow");
        }
        private void Ping(object sender, RoutedEventArgs e)
        {
            Program.Ping();
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            // 切换侧边栏的可见性
            if (SideBar.Visibility == Visibility.Collapsed)
            {
                SideBar.Visibility = Visibility.Visible;
            }
            else
            {
                SideBar.Visibility = Visibility.Collapsed;
            }
        }
    }
}