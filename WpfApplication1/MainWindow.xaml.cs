﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Investor> InvCol = new ObservableCollection<Investor>();
        public static Investor Anton = new Investor("Anton", "Logvinov", 23, "Luga");
        public static Investor Grisha = new Investor("Grisha", "Urgant", 57, "Piter");
        public MainWindow()
        {
            InvCol.Add(Anton);
            InvCol.Add(Grisha);
            InitializeComponent();
        }
        
    }
}
