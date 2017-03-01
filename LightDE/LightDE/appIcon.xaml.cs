﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

namespace LightDE
{
    /// <summary>
    /// Interaction logic for appIcon.xaml
    /// </summary>
    public partial class appIcon : UserControl
    {
        public string Path;
        public appIcon()
        {
            InitializeComponent();
        }
        public appIcon(string Name, Bitmap icon, string Path)
        {
            InitializeComponent();
            ImageSource s = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(icon.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            this.icon.Source = s;
            this.name.Content = Name;
            this.Path = Path;
            this.Loaded += Icon_Loaded;
            this.MouseLeftButtonUp += (object sender, MouseButtonEventArgs e) => { MessageBox.Show("Hi!");  Process.Start(Path); };
            this.MouseUp += (object sender, MouseButtonEventArgs e) => { MessageBox.Show("Hi!"); Process.Start(Path); };
        }


        private void Icon_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void run(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find the path!");
            }
        }
    }
}
