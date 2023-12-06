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
    /// Interaction logic for search_page.xaml
    /// </summary>
    public partial class search_page : Page
    {
        yarabbEntities db = new yarabbEntities();
        public search_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr hh = new userr();
            hh = db.userrs.FirstOrDefault(x => x.Username == username_txt.Text && x.passwordd == password_txt.Text);
            if (hh.Username == "" && hh.passwordd == "")
            {
                MessageBox.Show("search 7sl");
            }
            else if (hh.Username != "" && hh.passwordd != "")
            {
                MessageBox.Show("search 7sl");
            }
            else if (hh.Username == "" && hh.passwordd != "")
            {
                MessageBox.Show("search 7sl");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userr dd = new userr();
            dd = db.userrs.FirstOrDefault(x => x.Username == username_txt.Text);
            dd.passwordd = password_txt.Text;
            db.userrs.Remove(dd);
            db.SaveChanges();
        }
    }
}
