using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget_passPage.xaml
    /// </summary>
    public partial class forget_passPage : Page
    {
        yarabbEntities db = new yarabbEntities();
        public forget_passPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr gg = new userr();

            gg = db.userrs.FirstOrDefault(x => x.Username == user_txt.Text);
            gg.passwordd = pass_txt.Text;
            db.userrs.AddOrUpdate(gg);
            db.SaveChanges();
            MessageBox.Show("updateed succ");
        }

        private void user_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void con_pass_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
