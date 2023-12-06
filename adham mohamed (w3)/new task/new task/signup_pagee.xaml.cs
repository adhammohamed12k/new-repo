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
    /// Interaction logic for signup_pagee.xaml
    /// </summary>
    public partial class signup_pagee : Page
    {
        yarabbEntities db = new yarabbEntities();
        string Gender;
        public signup_pagee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            userr gg = new userr();
            gg.Username = user_txt.Text;
            gg.passwordd = pass_txt.Text;
            int dd = int.Parse(age_txt.Text);
            gg.age = dd;
            gg.Gender = Gender;
            gg.Phone_number = PhoneNum_txt.Text;
            gg.city = com.Text;
            MessageBox.Show("added succ");
            if (gg.Username == user_txt.Text)
            {
                mypagee jj = new mypagee();
                string user = user_txt.Text;
                this.NavigationService.Navigate(jj);
            }
        }

     
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signin_page kk = new signin_page();
            this.NavigationService.Navigate(kk);
        }
/// <summary>
/// //////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Gender = "female";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Gender = "male";
        }

        private void pass_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool IsValid(String Pass)
            {
                bool upper, lower, num, sympole;
                upper = lower = num = sympole = false;
                string spatiel = "!@#$%^&*()";
                foreach (char c in Pass)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        upper = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        lower = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        num = true;
                    }
                    else if (spatiel.Contains(c))
                    {
                        sympole = true;
                    }
                }
                return upper && lower && num && sympole;

            }
        }

        private void PhoneNum_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void user_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void com_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
