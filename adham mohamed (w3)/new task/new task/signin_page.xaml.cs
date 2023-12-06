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
    /// Interaction logic for signin_page.xaml
    /// </summary>
    public partial class signin_page : Page
    {
        yarabbEntities db = new yarabbEntities();
        public signin_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr ff = new userr();
            ff = db.userrs.FirstOrDefault(x => x.Username == user_txt.Text && x.passwordd == pass_txt.Text);
            if (ff.Username == user_txt.Text && ff.passwordd == pass_txt.Text)
            {
                mypagee hh = new mypagee();
                this.NavigationService.Navigate(hh);
                MessageBox.Show("اشطر واحد كده كده");
            }
            else
            {
                MessageBox.Show("حاول تاني يحبيبي");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forget_passPage dd = new forget_passPage();
            this.NavigationService.Navigate(dd);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            admin_Page ww = new admin_Page();
            this.NavigationService.Navigate(ww);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            signup_pagee gv = new signup_pagee();
            this.NavigationService.Navigate(gv);  
        }
    }
}
