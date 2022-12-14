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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long runningNo = 0;
        bool isRunning = true;
        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void asyncInvokeText(dynamic obj,string txt)
        {
            await Dispatcher.BeginInvoke((Action)(() => obj.Text = txt  ));
        }  
        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            isRunning = true;
            Task.Run(async () =>
            {
                while (isRunning)
                {
                    asyncInvokeText(tbStatus, "Status : " + runningNo.ToString());

                    await Task.Delay(1);
                    runningNo += 1;
                }
            });
        }
        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            isRunning = false;
        }
    }
}
