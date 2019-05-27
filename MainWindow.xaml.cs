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
using System.Diagnostics;

namespace TaskManagerWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TaskManager.ItemsSource = Process.GetProcesses();

        }


        private void TaskProcess_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Process proc in Process.GetProcesses())
                {
                    if(proc.Id == ((Process)TaskManager.SelectedItem ).Id)
                    {
                        proc.Kill();
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
