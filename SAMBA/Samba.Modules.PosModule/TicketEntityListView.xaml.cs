﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
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

namespace Samba.Modules.PosModule
{
    /// <summary>
    /// Interaction logic for TicketTagView.xaml
    /// </summary>

    [Export]
    public partial class TicketEntityListView : UserControl
    {
        [ImportingConstructor]
        public TicketEntityListView(TicketEntityListViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }

    private void FlexButton_Checked(object sender, RoutedEventArgs e)
    {

    }
  }
}
