﻿using System;
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

namespace Абоненты_VS
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

        private void Btn_click(object sender, RoutedEventArgs e)
        {

        }
        private void Btn_click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void Btn_click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void Btn_click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void Btn_click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
