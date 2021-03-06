﻿using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace BenWindow {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            this.Width = SystemParameters.WorkArea.Width;
            this.Height = SystemParameters.WorkArea.Height;
            this.Top = SystemParameters.WorkArea.Top;
            this.Left = SystemParameters.WorkArea.Left;

            this.Loaded += async delegate {
                await Task.Delay(250);                                
                toast.Visibility = Visibility.Visible;

                //REMOVE THIS
                await Task.Delay(1000);
                toast.Show("Hallo!", System.TimeSpan.FromMilliseconds(5000));
                await Task.Delay(5500);
                this.Close();
            };            
        }
    }
}
