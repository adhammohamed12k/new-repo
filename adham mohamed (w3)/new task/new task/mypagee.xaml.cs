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

namespace new_task
{
    /// <summary>
    /// Interaction logic for mypagee.xaml
    /// </summary>
    public partial class mypagee : Page
    {
        yarabbEntities db = new yarabbEntities();
        public mypagee()
        {
            InitializeComponent();
            signup_pagee hh = new signup_pagee();
            gridgg.ItemsSource = db.userrs.FirstOrDefault(x => x.Username == hh.user_txt.Text).ToList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signin_page ee = new signin_page();
            this.NavigationService.Navigate(ee);
        }
    }
}
