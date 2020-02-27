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

namespace CodeOutputPlugin.Views
{
    /// <summary>
    /// Interaction logic for CodeWindow.xaml
    /// </summary>
    public partial class CodeWindow : UserControl
    {
        public CodeWindow()
        {
            InitializeComponent();
        }

        private void CopyButtonClicked(object sender, RoutedEventArgs e)
        {
            TextBoxInstance.Focus();
            TextBoxInstance.SelectAll();
            if (!string.IsNullOrEmpty(TextBoxInstance.Text))
            {
                // from: https://stackoverflow.com/questions/68666/clipbrd-e-cant-open-error-when-setting-the-clipboard-from-net
                for (int i = 0; i < 11; i++)
                {
                    try
                    {
                        Clipboard.SetText(TextBoxInstance.Text);
                        return;
                    }
                    catch { }
                    System.Threading.Thread.Sleep(15);
                }




            }
        }
    }
}