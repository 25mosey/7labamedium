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

namespace lab7_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> list;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(100);
            list = new List<int>();
            string str = "";
            for (int i = 0; i < n; i++)
            {
                list.Add(random.Next(50));
                str += $"{list[i]} ";
            }
            Result.Text = str + "\n";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 4)
                {
                    if (i != list.Count - 1)
                        list.RemoveAt(i + 1);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                {
                    list.Insert(i, 0);
                    i++;
                }
            }
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                str += $"{list[i]} ";
            }
            Result.Text += str;

        }
    }
}
