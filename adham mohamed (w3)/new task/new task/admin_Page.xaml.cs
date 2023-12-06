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
    /// Interaction logic for admin_Page.xaml
    /// </summary>
    public partial class admin_Page : Page
    {
        yarabbEntities db = new yarabbEntities();
        public admin_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adminn ff = new adminn();
            ff = db.adminns.FirstOrDefault(x => x.admin_UserName == user_txt.Text);
            ff.admin_Password = pass_txt.Text;
            if (ff.admin_UserName == user_txt.Text)
            {
                search_page hh = new search_page();
                this.NavigationService.Navigate(hh);
            }
        }
    }
}
